namespace SchoolApp.Views.School_Information
{
    partial class FrmClassRoom
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtClassName = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.chkEnabled = new DevExpress.XtraEditors.ToggleSwitch();
            this.cbxClassLevel = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dgvClassRoom = new DevExpress.XtraGrid.GridControl();
            this.gridViewClassRoom = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSelect = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtClassName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnabled.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxClassLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClassRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txtClassName);
            this.panelControl1.Controls.Add(this.simpleButton3);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.chkEnabled);
            this.panelControl1.Controls.Add(this.cbxClassLevel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 39);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(926, 136);
            this.panelControl1.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(857, 26);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "نام کلاس";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(857, 96);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 20);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "وضعیت";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(857, 62);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(18, 20);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "پایه";
            // 
            // txtClassName
            // 
            this.txtClassName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClassName.Location = new System.Drawing.Point(554, 22);
            this.txtClassName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Parmida_ActivePlusMultiKeys = false;
            this.txtClassName.Size = new System.Drawing.Size(295, 26);
            this.txtClassName.TabIndex = 1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.txtClassName, conditionValidationRule1);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.ImageOptions.Image = global::SchoolApp.Properties.Resources.cancel_32x322;
            this.simpleButton3.Location = new System.Drawing.Point(284, 78);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(107, 43);
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = "بستن";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ImageOptions.Image = global::SchoolApp.Properties.Resources.saveto_32x32;
            this.btnSave.Location = new System.Drawing.Point(397, 78);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 43);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "ذخیره";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkEnabled
            // 
            this.chkEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkEnabled.EditValue = true;
            this.chkEnabled.Location = new System.Drawing.Point(670, 91);
            this.chkEnabled.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Parmida_ActivePlusMultiKeys = false;
            this.chkEnabled.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.chkEnabled.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.chkEnabled.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.chkEnabled.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.chkEnabled.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.chkEnabled.Properties.OffText = "غیرفعال";
            this.chkEnabled.Properties.OnText = "فعال";
            this.chkEnabled.Size = new System.Drawing.Size(179, 30);
            this.chkEnabled.TabIndex = 1;
            // 
            // cbxClassLevel
            // 
            this.cbxClassLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxClassLevel.Location = new System.Drawing.Point(684, 58);
            this.cbxClassLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxClassLevel.Name = "cbxClassLevel";
            this.cbxClassLevel.Parmida_ActivePlusMultiKeys = false;
            this.cbxClassLevel.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxClassLevel.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxClassLevel.Properties.AppearanceDropDown.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxClassLevel.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxClassLevel.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxClassLevel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxClassLevel.Properties.NullText = "";
            this.cbxClassLevel.Properties.PopupSizeable = false;
            this.cbxClassLevel.Properties.PopupView = this.searchLookUpEdit1View;
            this.cbxClassLevel.Size = new System.Drawing.Size(165, 26);
            this.cbxClassLevel.TabIndex = 1;
            this.cbxClassLevel.EditValueChanged += new System.EventHandler(this.cbxClassLevel_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.DetailTip.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.Empty.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.EvenRow.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.FixedLine.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.GroupButton.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.GroupRow.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.HorzLine.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.OddRow.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.Preview.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.Row.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.VertLine.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.searchLookUpEdit1View.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.gridColumn7.Caption = "مقطع تحصیلی";
            this.gridColumn7.FieldName = "ClassLevel1";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dgvClassRoom);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 175);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(926, 340);
            this.panelControl2.TabIndex = 5;
            // 
            // dgvClassRoom
            // 
            this.dgvClassRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClassRoom.Location = new System.Drawing.Point(2, 2);
            this.dgvClassRoom.MainView = this.gridViewClassRoom;
            this.dgvClassRoom.Name = "dgvClassRoom";
            this.dgvClassRoom.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnSelect});
            this.dgvClassRoom.Size = new System.Drawing.Size(922, 336);
            this.dgvClassRoom.TabIndex = 2;
            this.dgvClassRoom.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewClassRoom});
            // 
            // gridViewClassRoom
            // 
            this.gridViewClassRoom.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridViewClassRoom.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewClassRoom.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gridViewClassRoom.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewClassRoom.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gridViewClassRoom.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewClassRoom.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gridViewClassRoom.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewClassRoom.Appearance.Empty.Options.UseTextOptions = true;
            this.gridViewClassRoom.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewClassRoom.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gridViewClassRoom.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewClassRoom.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gridViewClassRoom.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewClassRoom.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gridViewClassRoom.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewClassRoom.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gridViewClassRoom.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewClassRoom.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridViewClassRoom.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewClassRoom.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridViewClassRoom.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewClassRoom.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridViewClassRoom.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewClassRoom.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gridViewClassRoom.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewClassRoom.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridViewClassRoom.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewClassRoom.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridViewClassRoom.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewClassRoom.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridViewClassRoom.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewClassRoom.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewClassRoom.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewClassRoom.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gridViewClassRoom.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewClassRoom.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridViewClassRoom.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewClassRoom.Appearance.OddRow.Options.UseTextOptions = true;
            this.gridViewClassRoom.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewClassRoom.Appearance.Preview.Options.UseTextOptions = true;
            this.gridViewClassRoom.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewClassRoom.Appearance.Row.Options.UseTextOptions = true;
            this.gridViewClassRoom.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewClassRoom.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gridViewClassRoom.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewClassRoom.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gridViewClassRoom.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewClassRoom.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gridViewClassRoom.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewClassRoom.Appearance.VertLine.Options.UseTextOptions = true;
            this.gridViewClassRoom.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewClassRoom.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridViewClassRoom.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewClassRoom.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridViewClassRoom.GridControl = this.dgvClassRoom;
            this.gridViewClassRoom.Name = "gridViewClassRoom";
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.gridColumn1.Caption = "ردیف";
            this.gridColumn1.FieldName = "ClassID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.gridColumn2.Caption = "نام کلاس";
            this.gridColumn2.FieldName = "ClassName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 211;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.gridColumn3.Caption = "مقطع تحصیلی";
            this.gridColumn3.FieldName = "classlevel1.ClassLevel1";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 211;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.gridColumn4.Caption = "تاریخ ثبت";
            this.gridColumn4.FieldName = "ClassRegisterDate";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 124;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.gridColumn5.Caption = "وضعیت";
            this.gridColumn5.FieldName = "ClassRoomEnable";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 126;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.gridColumn6.ColumnEdit = this.btnSelect;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            this.gridColumn6.Width = 38;
            // 
            // btnSelect
            // 
            this.btnSelect.AutoHeight = false;
            editorButtonImageOptions1.Image = global::SchoolApp.Properties.Resources.prev_16x16;
            serializableAppearanceObject1.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            serializableAppearanceObject2.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            serializableAppearanceObject3.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            serializableAppearanceObject4.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.btnSelect.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnSelect.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnSelect_ButtonClick);
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = global::SchoolApp.Properties.Resources.boposition2_32x32;
            this.groupControl1.Controls.Add(this.panelControl2);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(930, 517);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "کلاس های مدرسه";
            // 
            // FrmClassRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 517);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmClassRoom";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "کلاس های مدرسه";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtClassName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnabled.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxClassLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClassRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtClassName;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl dgvClassRoom;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewClassRoom;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ToggleSwitch chkEnabled;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSelect;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.SearchLookUpEdit cbxClassLevel;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
    }
}