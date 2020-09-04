using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SchoolApp.Views.School_Information
{
    public partial class FrmClassRoom : DevExpress.XtraEditors.XtraForm
    {
        private ISchoolProcess schoolProcess;
        private classroom newClass;

        public FrmClassRoom(ISchoolProcess schoolProcess)
        {
            this.schoolProcess = schoolProcess;
            InitializeComponent();
            newClass = new classroom();


        }
        pr
        private void simpleButton3_Click(object sender, System.EventArgs e)
        {
            Close();
        }


        private async void btnSave_Click(object sender, System.EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                if (newClass.ClassID > 0)
                {
                    newClass = new classroom()
                    {
                        ClassName = txtClassName.EditValue.ToString(),
                        ClassLevel = cbxClassLevel.Text,
                        ClassRegisterDate = DateTime.Now,
                        ClassRoomEnable = Convert.ToBoolean(chkEnabled.EditValue),
                    };
                }
                var result = await schoolProcess.ClassRoomCRUD(newClass);
                if (result)
                {
                    XtraMessageBox.Show(PublicVar.SuccessSaveToDatabase, Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                else
                {
                    XtraMessageBox.Show(PublicVar.ErrorSaveToDatabase, Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private async void btnSelect_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("ClassID") != null)
            {
               // var selectClassroom = (classroom);
                newClass = new classroom();
                var FocusedRow = gridView1.GetFocusedRow();
                var selectFocusedRow = (classroom)FocusedRow;
                newClass = await schoolProcess.GetClassroomByClassId(selectFocusedRow.ClassID);
                txtClassName.EditValue = newClass.ClassName;
                chkEnabled.EditValue = newClass.ClassRoomEnable;
                cbxClassLevel.SelectedItem = newClass.ClassLevel;
            }
        }
    }
}
