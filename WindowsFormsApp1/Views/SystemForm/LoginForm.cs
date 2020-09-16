using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace SchoolApp.Views.SystemForm
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        private ISetupProcess SetupProcess;
        public LoginForm(ISetupProcess SetupProcess)
        {
            this.SetupProcess = SetupProcess;
            InitializeComponent();
            ChechingUser();
            this.AcceptButton = btnLogin;
            this.CancelButton = btnClose;
            txtUserName.EditValue = "admin";
            txtPassword.EditValue = "admin";

        }

        private  void ChechingUser()
        {
            var schoolname =  SetupProcess.GetSchoolInformation();
            PublicVar.SchoolName = schoolname.SchoolName;
            var result =  SetupProcess.GetAdminUsers();
            if (result)
            {
                var str = $"کاربر مدیر مدرسه با نام کاربری admin  و رمز عبور admin ایجاد شد";
                XtraMessageBox.Show(str, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.EditValue = "admin";
                txtPassword.EditValue = "admin";
                btnLogin.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private  void btnLogin_Click(object sender, EventArgs e)
        {
            if (SetupProcess.SuccessAccount(txtUserName.EditValue.ToString(),txtPassword.EditValue.ToString()))
            {
                DialogResult = DialogResult.OK;
                return;
            }
            XtraMessageBox.Show(PublicVar.NoSuccessLogin, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
