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

namespace SchoolApp.Views.School_Information
{
    public partial class FrmAddTagCard : DevExpress.XtraEditors.XtraForm
    {
        private IRfid_Class rfidClass;
        public FrmAddTagCard(IRfid_Class rfidClass)
        {
            this.rfidClass = rfidClass;
            InitializeComponent();
        }

        private void ClearForm()
        {
            txtTagNumber.ResetText();
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var result =await rfidClass.GetRFID_ByTagID(txtTagNumber.EditValue.ToString().Trim());
            if (result == null)
            {

                var newTag = new Tag();
                newTag.TagID_HEX = txtTagNumber.EditValue.ToString().Trim();
                newTag.Enabled = true; 
                var resultSave =await rfidClass.AddNewTagCard(newTag);
                if (resultSave)
                {
                    XtraMessageBox.Show(PublicVar.SuccessSaveToDatabase, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                    XtraMessageBox.Show(PublicVar.ErrorSaveToDatabase, Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else
                XtraMessageBox.Show(PublicVar.DublicateRecord, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
