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
    public partial class StudentForm : DevExpress.XtraEditors.XtraForm
    {
        private ISetupProcess setupProcess;
        private readonly ISchoolProcess schoolProcess;
        private AcademicYear years;
        private Student newstudent;

        public StudentForm(ISetupProcess setupProcess, ISchoolProcess schoolProcess)
        {
            this.schoolProcess = schoolProcess;
            InitializeComponent();
            this.setupProcess = setupProcess;
            ClearForm();
            newstudent  = new Student();
        }

        private  void AcademicYearsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void ClearForm()
        {
            txtName.ResetText();
            txtFamily.ResetText();
            txtStudentCode.ResetText();
            txtNatinalCode.ResetText();
            txtFather.ResetText();
            txtmather.ResetText();
            txtHomePhone.ResetText();
            txtFatherMobile.ResetText();
            txtMatherMobile.ResetText();
            txtSMS.ResetText();
            dateBrithDate.DateTime = DateTime.Now;
            txtName.Focus();
            newstudent = new Student();
            
            dgvStudentList.DataSource = await schoolProcess.GetAllStudent();
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                if (newstudent.ID > 0)
                {
                    newstudent.FName = txtName.Text;
                    newstudent.LName = txtFamily.Text;
                    newstudent.FullName = $"{txtName.Text} {txtFamily.Text}";
                    newstudent.StudentCode = txtStudentCode.Text;
                    newstudent.StudentNatinalCode = txtNatinalCode.Text;
                    newstudent.FatherName = txtFather.Text;
                    newstudent.MotherName = txtmather.Text;
                    newstudent.HomePhone = txtHomePhone.Text;
                    newstudent.FatherPhone = txtFatherMobile.Text;
                    newstudent.MotherPhone = txtMatherMobile.Text;
                    newstudent.SMS = txtSMS.Text;
                    newstudent.BrithDate = dateBrithDate.DateTime.Date;
                    newstudent.RegDate = DateTime.Now;
                    newstudent.Enabled = true;
                }
                else
                {
                    newstudent = new Student();
                    newstudent.FName = txtName.Text;
                    newstudent.LName = txtFamily.Text;
                    newstudent.FullName = $"{txtName.Text} {txtFamily.Text}";
                    newstudent.StudentCode = txtStudentCode.Text;
                    newstudent.StudentNatinalCode = txtNatinalCode.Text;
                    newstudent.FatherName = txtFather.Text;
                    newstudent.MotherName = txtmather.Text;
                    newstudent.HomePhone = txtHomePhone.Text;
                    newstudent.FatherPhone = txtFatherMobile.Text;
                    newstudent.MotherPhone = txtMatherMobile.Text;
                    newstudent.SMS = txtSMS.Text;
                    newstudent.BrithDate = dateBrithDate.DateTime.Date;
                    newstudent.RegDate = DateTime.Now;
                    newstudent.Enabled = true;
                }
                var result = await schoolProcess.AppendStudent(newstudent);
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
            {
                XtraMessageBox.Show(PublicVar.NoComplateForm, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSelectStudent_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("ID") != null)
            {
                newstudent = new Student();
                var FocusedRow = gridView1.GetFocusedRow();
                var selectFocusedRow = (Student)FocusedRow;
                
                newstudent = await schoolProcess.GetStudentById(selectFocusedRow.ID);
                txtName.Text = newstudent.FName;
                txtFamily.Text = newstudent.LName;
                txtFather.Text = newstudent.FatherName;
                txtFatherMobile.Text = newstudent.FatherPhone;
                txtHomePhone.Text = newstudent.HomePhone;
                txtMatherMobile.Text = newstudent.MotherPhone;
                txtNatinalCode.Text = newstudent.StudentNatinalCode.ToString();
                txtSMS.Text = newstudent.SMS;
                txtStudentCode.Text = newstudent.StudentCode;
                txtmather.Text = newstudent.MotherName;
                dateBrithDate.DateTime = newstudent.BrithDate;
            }
        }
    }
}
