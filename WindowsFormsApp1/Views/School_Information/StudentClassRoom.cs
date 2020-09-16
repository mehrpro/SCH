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
        private AcademicYear years;
        private Registered regStudent;
        private ViewList_ClassRoom selectClass;
        private bool CheckedRegister;

        public StudentClassRoom(ISetupProcess setupProcess, ISchoolProcess schoolProcess)
        {
            this.schoolProcess = schoolProcess;
            InitializeComponent();
            this.setupProcess = setupProcess;
            ClearForm();
            SetupForm();
            regStudent = new Registered();
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

            regStudent = new Registered();
            if (selectClass == null)
            {
                return;
            }
            cbxStudent.Properties.DataSource = await schoolProcess.GetAllStudentForComboBox();
            dgvStudentClassRoom.DataSource = await schoolProcess.GetRegisterListByClassRoomId(selectClass.شناسه_کلاس);
            gridViewStudentClassRoom.RefreshData();
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            
            if (dxValidationProvider1.Validate())
            {

                    
                    regStudent = new Registered();
                    regStudent.Class_FK = Convert.ToByte(cbxClassName.EditValue);
                    regStudent.Student_FK = Convert.ToInt32(cbxStudent.EditValue);
                    regStudent.Enabled = true;
                    regStudent.Years_FK = PublicVar.AcademicYearsID;
                    regStudent.School_FK = PublicVar.schoolid;
                     //CheckedRegister = await schoolProcess.RegisterdSudent(Convert.ToInt32(cbxStudent.EditValue));
               

                //if (!CheckedRegister)
                //{
                    var result =  schoolProcess.AppendRegisterdStudent(regStudent);
                    if (result)
                    {
                        XtraMessageBox.Show(PublicVar.SuccessSaveToDatabase, Text, MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ClearForm();
                    }
                    else
                        XtraMessageBox.Show(PublicVar.ErrorSaveToDatabase, Text, MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                //}
                //else
                //    XtraMessageBox.Show("دانش آموز قبلا در کلاس بندی ثبت شده است", Text, MessageBoxButtons.OK,
                //        MessageBoxIcon.Error);

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
            var selectrow = (Registered)focused;
            regStudent = new Registered();
            regStudent = selectrow;
            txtFather.Text = regStudent.Student.FatherName;
            txtBrithDate.Text = regStudent.Student.BrithDate.ConvertDateToPersian();
            txtNatinalCode.Text = regStudent.Student.StudentNatinalCode;
            cbxStudent.EditValue = regStudent.Student_FK;

        }

        private async void btnRemove_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gridViewStudentClassRoom.GetFocusedRowCellValue("ID") == null) return;
            var focused = gridViewStudentClassRoom.GetFocusedRow();
            var selectrow = (Registered)focused;
            var result = schoolProcess.DisableRegister(selectrow.ID);
            if (result)
            {
                cbxStudent.Properties.DataSource = await schoolProcess.GetAllStudentForComboBox();
                ClearForm();
            }
        }
    }
}
