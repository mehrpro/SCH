namespace SchoolApp.Views.School_Information
{
    partial class AcademicYearsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.StartDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.FinishDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinishDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinishDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(848, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "سال تحصیلی";
            // 
            // textEdit1
            // 
            this.textEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit1.Location = new System.Drawing.Point(702, 47);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Parmida_ActivePlusMultiKeys = false;
            this.textEdit1.Size = new System.Drawing.Size(140, 26);
            this.textEdit1.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(848, 118);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 20);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "آغاز سال تحصیلی";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(848, 144);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(87, 20);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "پایان سال تحصیلی";
            // 
            // StartDateEdit
            // 
            this.StartDateEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartDateEdit.EditValue = null;
            this.StartDateEdit.Location = new System.Drawing.Point(702, 111);
            this.StartDateEdit.Name = "StartDateEdit";
            this.StartDateEdit.Parmida_ActivePlusMultiKeys = false;
            this.StartDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StartDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StartDateEdit.Properties.Parmida_CheckDateOnLeave = false;
            this.StartDateEdit.Properties.Parmida_CheckEmptyFillDateOnEnter = false;
            this.StartDateEdit.Size = new System.Drawing.Size(140, 26);
            this.StartDateEdit.TabIndex = 2;
            // 
            // FinishDateEdit
            // 
            this.FinishDateEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FinishDateEdit.EditValue = null;
            this.FinishDateEdit.Location = new System.Drawing.Point(702, 143);
            this.FinishDateEdit.Name = "FinishDateEdit";
            this.FinishDateEdit.Parmida_ActivePlusMultiKeys = false;
            this.FinishDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FinishDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FinishDateEdit.Properties.Parmida_CheckDateOnLeave = false;
            this.FinishDateEdit.Properties.Parmida_CheckEmptyFillDateOnEnter = false;
            this.FinishDateEdit.Size = new System.Drawing.Size(140, 26);
            this.FinishDateEdit.TabIndex = 3;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.ImageOptions.Image = global::SchoolApp.Properties.Resources.cancel_32x322;
            this.simpleButton3.Location = new System.Drawing.Point(438, 126);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(107, 43);
            this.simpleButton3.TabIndex = 6;
            this.simpleButton3.Text = "بستن";
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = global::SchoolApp.Properties.Resources.today_32x32;
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.textEdit2);
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Controls.Add(this.StartDateEdit);
            this.groupControl1.Controls.Add(this.FinishDateEdit);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(949, 358);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "سال تحصیلی";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ImageOptions.Image = global::SchoolApp.Properties.Resources.saveto_32x32;
            this.btnSave.Location = new System.Drawing.Point(551, 126);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 43);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "ذخیره";
            // 
            // textEdit2
            // 
            this.textEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit2.Location = new System.Drawing.Point(436, 79);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Parmida_ActivePlusMultiKeys = false;
            this.textEdit2.Size = new System.Drawing.Size(406, 26);
            this.textEdit2.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(848, 82);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 20);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "توضیحات";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(625, 50);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 20);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "1399-1400";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Location = new System.Drawing.Point(473, 201);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(369, 20);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "سال تحصیلی به صورت یک اصل از پیش تعیین شده طراحی و محاسبه میگردد";
            // 
            // AcademicYearsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 358);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AcademicYearsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "سال تحصیلی";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinishDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinishDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit StartDateEdit;
        private DevExpress.XtraEditors.DateEdit FinishDateEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit textEdit2;
    }
}