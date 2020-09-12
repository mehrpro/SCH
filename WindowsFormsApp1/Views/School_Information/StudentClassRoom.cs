using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DevExpress.XtraEditors;

namespace SchoolApp.Views.School_Information
{
    public partial class StudentClassRoom : DevExpress.XtraEditors.XtraForm
    {
        private ISetupProcess setupProcess;
        private readonly ISchoolProcess schoolProcess;
        private academic_year years;
        private registered regStudent;
        private ViewList_ClassRoom selectClass;
        private bool CheckedRegister;

        public StudentClassRoom(ISetupProcess setupProcess, ISchoolProcess schoolProcess)
        {
            this.schoolProcess = schoolProcess;
            InitializeComponent();
            this.setupProcess = setupProcess;
            ClearForm();
            SetupForm();
            regStudent = new registered();
            txtAcademicYears.Text = PublicVar.YearsName;

        }

        private async void SetupForm()
        {
            cbxClassName.Properties.DataSource = await schoolProcess.GetAllClassRoomByLevel();
            cbxClassName.Properties.DisplayMember = "نام_کلاس";
            cbxClassName.Properties.ValueMember = "شناسه_کلاس";

            cbxStudent.Properties.DataSource = await schoolProcess.GetAllStudentForComboBox();
            cbxStudent.Properties.DisplayMember = "نام";
            cbxStudent.Properties.ValueMember = "شناسه";


        }

        private async void AcademicYearsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void ClearForm()
        {


            cbxStudent.ResetText();

            regStudent = new registered();
            if (selectClass == null)
            {
                return;
            }
            dgvStudentClassRoom.DataSource = await schoolProcess.GetRegisterListByClassRoomId(selectClass.شناسه_کلاس);
            gridViewStudentClassRoom.RefreshData();
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            
            if (dxValidationProvider1.Validate())
            {
                if (regStudent.id > 0)
                {
                    regStudent.class_fk = Convert.ToByte(cbxClassName.EditValue);
                    regStudent.student_fk = Convert.ToInt64(cbxStudent.EditValue);
                    CheckedRegister = false;
                }
                else
                {
                    
                    regStudent = new registered();
                    regStudent.class_fk = Convert.ToByte(cbxClassName.EditValue);
                    regStudent.student_fk = Convert.ToInt64(cbxStudent.EditValue);
                    regStudent.enabled = true;
                    regStudent.years_fk = PublicVar.AcademicYearsID;
                    regStudent.school_fk = PublicVar.schoolid;
                     CheckedRegister = await schoolProcess.RegisterdSudent(Convert.ToInt64(cbxStudent.EditValue));
                }

                if (!CheckedRegister)
                {
                    var result = await schoolProcess.AppendRegisterdStudent(regStudent);
                    if (result)
                    {
                        XtraMessageBox.Show(PublicVar.SuccessSaveToDatabase, Text, MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ClearForm();
                    }
                    else
                        XtraMessageBox.Show(PublicVar.ErrorSaveToDatabase, Text, MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
                else
                    XtraMessageBox.Show("دانش آموز قبلا در کلاس بندی ثبت شده است", Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

            }
            else
                XtraMessageBox.Show(PublicVar.NoComplateForm, Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }



        private void cbxStudent_EditValueChanged(object sender, EventArgs e)
        {
            var selectStudent = (ViewList_Student)cbxStudent.GetSelectedDataRow();
            if (selectStudent == null)
            {
                txtFather.ResetText();
                txtNatinalCode.ResetText();
                txtBrithDate.ResetText();
                return;
            }

            txtFather.Text = selectStudent.نام_پدر;
            txtNatinalCode.Text = selectStudent.کدملی;
            txtBrithDate.Text = selectStudent.متولد;
        }

        private async void cbxClassName_EditValueChanged(object sender, EventArgs e)
        {
            selectClass = (ViewList_ClassRoom)cbxClassName.GetSelectedDataRow();
            if (selectClass == null)
            {
                dgvStudentClassRoom.DataSource = null;
                gridViewStudentClassRoom.RefreshData();
                return;
            }
            //ClearForm();
            dgvStudentClassRoom.DataSource = await schoolProcess.GetRegisterListByClassRoomId(selectClass.شناسه_کلاس);
            gridViewStudentClassRoom.RefreshData();
        }

        private void btnSelectStudent_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gridViewStudentClassRoom.GetFocusedRowCellValue("id") == null) return;
            var focused = gridViewStudentClassRoom.GetFocusedRow();
            var selectrow = (registered)focused;
            regStudent = new registered();
            regStudent = selectrow;
            txtFather.Text = regStudent.student.FatherName;
            txtBrithDate.Text = regStudent.student.BrithDate.Value.ConvertDateToPersian();
            txtNatinalCode.Text = regStudent.student.StudentNatinalCode;
            cbxStudent.EditValue = regStudent.student_fk;

        }

    }
}
