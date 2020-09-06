﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SchoolApp.Views.School_Information;

namespace SchoolApp.Views.SystemForm
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private ISetupProcess setupProcess;
        private school selectSchool;
        public MainForm(ISetupProcess setupProcess)
        {
            this.setupProcess = setupProcess;
            InitializeComponent();
            this.Text = PublicVar.SchoolName;
       
        }



        private async void menuTabItemSchool_SelectedChanged(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            selectSchool = await setupProcess.GetSchoolInformation();
            txtSchoolName.EditValue = selectSchool.SchoolName;
            txtSchoolAddress.EditValue = selectSchool.SchoolAddress;
            txtSchoolTel.EditValue = selectSchool.SchoolTel;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            selectSchool.SchoolName = txtSchoolName.EditValue.ToString();
            selectSchool.SchoolAddress = txtSchoolAddress.EditValue.ToString();
            selectSchool.SchoolTel = txtSchoolTel.EditValue.ToString();
            var result = await setupProcess.ModifySchoolInformation(selectSchool);
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

        private void btnNewCart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form c in this.MdiChildren) c.Close();
            var container = new StructureMap.Container(new TypeRegistery());
            var frm = container.GetInstance<FrmAddTagCard>();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnClassRoom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form c in this.MdiChildren) c.Close();
            var container = new StructureMap.Container(new TypeRegistery());
            var frm = container.GetInstance<FrmClassRoom>();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnAcademicYears_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form c in this.MdiChildren) c.Close();
            var container = new StructureMap.Container(new TypeRegistery());
            var frm = container.GetInstance<AcademicYearsForm>();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
