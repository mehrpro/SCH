using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;

namespace SchoolApp.Views.School_Information
{
    public partial class TagStudentForm : DevExpress.XtraEditors.XtraForm
    {
        
        private ISchoolProcess schoolProcess;
        public TagStudentForm(ISchoolProcess schoolProcess)
        {
            
            this.schoolProcess = schoolProcess;
            InitializeComponent();
            cbxStudent.Properties.DisplayMember = "FullName";
            cbxStudent.Properties.ValueMember = "ID";
            cbxTAG.Properties.DisplayMember = "TagID_HEX";
            cbxTAG.Properties.ValueMember = "ID";
            SetupForm();

        }

        private async void SetupForm()
        {
            cbxStudent.Properties.DataSource = await schoolProcess.GetAllStudent();
            cbxTAG.Properties.DataSource = await schoolProcess.GetAllNoEnabled();
            cbxStudent.EditValue = cbxTAG.EditValue = null;
        }


        private async void btnSave_Click(object sender, EventArgs e)
        {
            var registerTag = new StudentTAG();
            registerTag.Student_FK = Convert.ToInt32(cbxStudent.EditValue);
            registerTag.TagID_FK = Convert.ToInt32(cbxTAG.EditValue);
            var en = await schoolProcess.GetStudentTAGById(Convert.ToInt32(cbxStudent.EditValue));
            if (en == null)
            {
                var resultSave = await schoolProcess.AddStudentTAG(registerTag);
                if (resultSave)
                {
                    XtraMessageBox.Show(PublicVar.SuccessSaveToDatabase, Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    SetupForm();

                }
                else
                {
                    XtraMessageBox.Show(PublicVar.ErrorSaveToDatabase, Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                var str =
                    $"برای دانش آموز {en.Student.FullName} قبلا کارت صادره شده است آیا قصد تغییر کارت را دارید";
                var dialogResult = XtraMessageBox.Show(str, Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var resultDisabled = await schoolProcess.ChangeStudentTAG(en.ID, registerTag);
                    if (resultDisabled)
                    {
                        XtraMessageBox.Show($"کارت جدید برای {en.Student.FullName} صادر شد", Text, MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        SetupForm();
                    }
                    else
                    {
                        XtraMessageBox.Show($"کارت {en.Tag.TagID_HEX} غیر فعال نشد با مدیر سیستم تماس بگیرید", Text,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                }
            }

        }
    }
}
