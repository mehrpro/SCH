using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;

namespace SchoolApp.Views.School_Information
{
    public partial class FrmClassRoom : DevExpress.XtraEditors.XtraForm
    {
        private ISchoolProcess schoolProcess;
        private ClassRoom newClass;

        public FrmClassRoom(ISchoolProcess schoolProcess)
        {
            this.schoolProcess = schoolProcess;
            InitializeComponent();
            newClass = new ClassRoom();
            setup();
        }

        private async void setup()
        {
            cbxClassLevel.Properties.DataSource = await schoolProcess.ListLevelClass();
            cbxClassLevel.Properties.DisplayMember = "ClassLevel1";
            cbxClassLevel.Properties.ValueMember = "ID";
            cbxClassLevel.EditValue = 1;
        }
        private void simpleButton3_Click(object sender, System.EventArgs e) => Close();
        
        private async void btnSave_Click(object sender, System.EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                if (newClass.ClassID < 1)
                {
                    newClass = new ClassRoom();
                    newClass.ClassName = txtClassName.EditValue.ToString();
                    newClass.ClassLevel_FK =Convert.ToInt32(cbxClassLevel.EditValue);
                    newClass.ClassRegisterDate = DateTime.Now;
                    newClass.ClassRoomEnable = true;
                }
                else
                {
                    newClass.ClassName = txtClassName.EditValue.ToString();
                    newClass.ClassLevel_FK = Convert.ToInt32(cbxClassLevel.EditValue);
                    //newClass.ClassRoomEnable = Convert.ToBoolean(chkEnabled.EditValue);
                }
                var result = await schoolProcess.ClassRoomCRUD(newClass);
                if (result)
                {
   
                    XtraMessageBox.Show(PublicVar.SuccessSaveToDatabase, Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    dgvClassRoom.DataSource = await schoolProcess.GetClassRoomByLevel();
                    txtClassName.ResetText();
                    //chkEnabled.EditValue = true;
                    cbxClassLevel.ReadOnly = false;
                    newClass = new ClassRoom();
                }
                else
                    XtraMessageBox.Show(PublicVar.ErrorSaveToDatabase, Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private async void btnSelect_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gridViewClassRoom.GetFocusedRowCellValue("ClassID") != null)
            {
                newClass = new ClassRoom();
                var FocusedRow = gridViewClassRoom.GetFocusedRow();
                var selectFocusedRow = (ClassRoom)FocusedRow;
                newClass = await schoolProcess.GetClassroomByClassId(selectFocusedRow.ClassID);
                txtClassName.EditValue = newClass.ClassName;
                //chkEnabled.EditValue = newClass.ClassRoomEnable;
                cbxClassLevel.EditValue = newClass.ClassLevel.ID;
                cbxClassLevel.ReadOnly = true;
            }
        }



        private async void cbxClassLevel_EditValueChanged(object sender, EventArgs e)
        {

            var selectClassLevel = (ClassLevel) cbxClassLevel.GetSelectedDataRow();
            if (selectClassLevel == null)
            {
                return;
                
            }
            dgvClassRoom.DataSource = await schoolProcess.GetClassRoomByLevel();
            //txtClassName.ResetText();
            //chkEnabled.EditValue = true;
        }
    }

    
}
