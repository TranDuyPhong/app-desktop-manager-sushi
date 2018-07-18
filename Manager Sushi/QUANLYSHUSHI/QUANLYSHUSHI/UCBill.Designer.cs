namespace QUANLYSHUSHI
{
    partial class UCBill
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCBill));
            this.gcBill = new DevExpress.XtraGrid.GridControl();
            this.gvBill = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXuatExcelBill = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbbSoBan = new DevExpress.XtraEditors.ComboBoxEdit();
            this.timeBill = new DevExpress.XtraEditors.TimeEdit();
            this.dtpTimKiem = new System.Windows.Forms.DateTimePicker();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnBillDaThanhToan = new DevExpress.XtraEditors.SimpleButton();
            this.btnTatCaBill = new DevExpress.XtraEditors.SimpleButton();
            this.btnBillChuaThanhToan = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBill)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbSoBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBill.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcBill
            // 
            this.gcBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcBill.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.White;
            this.gcBill.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gcBill.Location = new System.Drawing.Point(22, 15);
            this.gcBill.MainView = this.gvBill;
            this.gcBill.Name = "gcBill";
            this.gcBill.Size = new System.Drawing.Size(408, 181);
            this.gcBill.TabIndex = 25;
            this.gcBill.TabStop = false;
            this.gcBill.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBill});
            // 
            // gvBill
            // 
            this.gvBill.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gvBill.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gvBill.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gvBill.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvBill.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvBill.Appearance.GroupPanel.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.gvBill.Appearance.GroupPanel.Options.UseFont = true;
            this.gvBill.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gvBill.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gvBill.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gvBill.Appearance.Row.Options.UseBackColor = true;
            this.gvBill.Appearance.Row.Options.UseBorderColor = true;
            this.gvBill.Appearance.VertLine.BackColor = System.Drawing.Color.Black;
            this.gvBill.Appearance.VertLine.BackColor2 = System.Drawing.Color.Black;
            this.gvBill.Appearance.VertLine.BorderColor = System.Drawing.Color.Black;
            this.gvBill.Appearance.VertLine.Options.UseBackColor = true;
            this.gvBill.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvBill.Appearance.ViewCaption.BackColor = System.Drawing.Color.Blue;
            this.gvBill.Appearance.ViewCaption.BackColor2 = System.Drawing.Color.Blue;
            this.gvBill.Appearance.ViewCaption.BorderColor = System.Drawing.Color.Blue;
            this.gvBill.Appearance.ViewCaption.Options.UseBackColor = true;
            this.gvBill.Appearance.ViewCaption.Options.UseBorderColor = true;
            this.gvBill.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn17});
            this.gvBill.GridControl = this.gcBill;
            this.gvBill.Name = "gvBill";
            this.gvBill.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gvBill.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "ID";
            this.gridColumn11.FieldName = "ID";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.OptionsColumn.AllowFocus = false;
            this.gridColumn11.OptionsColumn.ReadOnly = true;
            this.gridColumn11.OptionsColumn.TabStop = false;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Ngày lập Bill";
            this.gridColumn12.FieldName = "ThoiGianLap";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.OptionsColumn.AllowFocus = false;
            this.gridColumn12.OptionsColumn.ReadOnly = true;
            this.gridColumn12.OptionsColumn.TabStop = false;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 0;
            this.gridColumn12.Width = 120;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Ngày kết Bill";
            this.gridColumn13.FieldName = "ThoiGianXuat";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.OptionsColumn.AllowFocus = false;
            this.gridColumn13.OptionsColumn.ReadOnly = true;
            this.gridColumn13.OptionsColumn.TabStop = false;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 1;
            this.gridColumn13.Width = 120;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Tại bàn";
            this.gridColumn14.FieldName = "TenBan";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.AllowEdit = false;
            this.gridColumn14.OptionsColumn.AllowFocus = false;
            this.gridColumn14.OptionsColumn.ReadOnly = true;
            this.gridColumn14.OptionsColumn.TabStop = false;
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 2;
            this.gridColumn14.Width = 50;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Tổng tiền";
            this.gridColumn17.FieldName = "TongTien";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.OptionsColumn.AllowEdit = false;
            this.gridColumn17.OptionsColumn.AllowFocus = false;
            this.gridColumn17.OptionsColumn.ReadOnly = true;
            this.gridColumn17.OptionsColumn.TabStop = false;
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 3;
            this.gridColumn17.Width = 100;
            // 
            // btnXuatExcelBill
            // 
            this.btnXuatExcelBill.AllowFocus = false;
            this.btnXuatExcelBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXuatExcelBill.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnXuatExcelBill.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnXuatExcelBill.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnXuatExcelBill.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcelBill.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcelBill.Appearance.Options.UseBackColor = true;
            this.btnXuatExcelBill.Appearance.Options.UseBorderColor = true;
            this.btnXuatExcelBill.Appearance.Options.UseFont = true;
            this.btnXuatExcelBill.Appearance.Options.UseForeColor = true;
            this.btnXuatExcelBill.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnXuatExcelBill.AppearanceHovered.BackColor2 = System.Drawing.Color.Gray;
            this.btnXuatExcelBill.AppearanceHovered.BorderColor = System.Drawing.Color.Gray;
            this.btnXuatExcelBill.AppearanceHovered.Options.UseBackColor = true;
            this.btnXuatExcelBill.AppearanceHovered.Options.UseBorderColor = true;
            this.btnXuatExcelBill.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXuatExcelBill.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXuatExcelBill.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXuatExcelBill.AppearancePressed.Options.UseBackColor = true;
            this.btnXuatExcelBill.AppearancePressed.Options.UseBorderColor = true;
            this.btnXuatExcelBill.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnXuatExcelBill.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatExcelBill.Image")));
            this.btnXuatExcelBill.Location = new System.Drawing.Point(278, 339);
            this.btnXuatExcelBill.Name = "btnXuatExcelBill";
            this.btnXuatExcelBill.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnXuatExcelBill.Size = new System.Drawing.Size(152, 38);
            this.btnXuatExcelBill.TabIndex = 7;
            this.btnXuatExcelBill.TabStop = false;
            this.btnXuatExcelBill.Text = "Xuất ra Excel";
            this.btnXuatExcelBill.Click += new System.EventHandler(this.btnXuatExcelBill_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.cbbSoBan);
            this.groupBox3.Controls.Add(this.timeBill);
            this.groupBox3.Controls.Add(this.dtpTimKiem);
            this.groupBox3.Controls.Add(this.btnTimKiem);
            this.groupBox3.Controls.Add(this.labelControl7);
            this.groupBox3.Controls.Add(this.labelControl5);
            this.groupBox3.Controls.Add(this.labelControl6);
            this.groupBox3.Location = new System.Drawing.Point(22, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 154);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // cbbSoBan
            // 
            this.cbbSoBan.Location = new System.Drawing.Point(80, 20);
            this.cbbSoBan.Name = "cbbSoBan";
            this.cbbSoBan.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cbbSoBan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSoBan.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cbbSoBan.Properties.Appearance.Options.UseBackColor = true;
            this.cbbSoBan.Properties.Appearance.Options.UseFont = true;
            this.cbbSoBan.Properties.Appearance.Options.UseForeColor = true;
            this.cbbSoBan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbbSoBan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbSoBan.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.cbbSoBan.Size = new System.Drawing.Size(121, 24);
            this.cbbSoBan.TabIndex = 0;
            this.cbbSoBan.TabStop = false;
            // 
            // timeBill
            // 
            this.timeBill.EditValue = new System.DateTime(2017, 6, 6, 0, 0, 0, 0);
            this.timeBill.Location = new System.Drawing.Point(101, 76);
            this.timeBill.Name = "timeBill";
            this.timeBill.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeBill.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.timeBill.Properties.Appearance.Options.UseFont = true;
            this.timeBill.Properties.Appearance.Options.UseForeColor = true;
            this.timeBill.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.timeBill.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeBill.Size = new System.Drawing.Size(100, 24);
            this.timeBill.TabIndex = 2;
            this.timeBill.TabStop = false;
            // 
            // dtpTimKiem
            // 
            this.dtpTimKiem.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpTimKiem.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtpTimKiem.CustomFormat = "dd/MM/yyyy";
            this.dtpTimKiem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimKiem.Location = new System.Drawing.Point(80, 50);
            this.dtpTimKiem.Name = "dtpTimKiem";
            this.dtpTimKiem.Size = new System.Drawing.Size(121, 22);
            this.dtpTimKiem.TabIndex = 1;
            this.dtpTimKiem.TabStop = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AllowFocus = false;
            this.btnTimKiem.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnTimKiem.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnTimKiem.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnTimKiem.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Appearance.Options.UseBackColor = true;
            this.btnTimKiem.Appearance.Options.UseBorderColor = true;
            this.btnTimKiem.Appearance.Options.UseFont = true;
            this.btnTimKiem.Appearance.Options.UseForeColor = true;
            this.btnTimKiem.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnTimKiem.AppearanceHovered.BackColor2 = System.Drawing.Color.Gray;
            this.btnTimKiem.AppearanceHovered.BorderColor = System.Drawing.Color.Gray;
            this.btnTimKiem.AppearanceHovered.Options.UseBackColor = true;
            this.btnTimKiem.AppearanceHovered.Options.UseBorderColor = true;
            this.btnTimKiem.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTimKiem.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTimKiem.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTimKiem.AppearancePressed.Options.UseBackColor = true;
            this.btnTimKiem.AppearancePressed.Options.UseBorderColor = true;
            this.btnTimKiem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(80, 106);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnTimKiem.Size = new System.Drawing.Size(121, 38);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.TabStop = false;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(18, 85);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(72, 15);
            this.labelControl7.TabIndex = 20;
            this.labelControl7.Text = "Thời gian lập";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(18, 29);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(36, 15);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "Số bàn";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(18, 57);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 15);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "Ngày lập";
            // 
            // btnBillDaThanhToan
            // 
            this.btnBillDaThanhToan.AllowFocus = false;
            this.btnBillDaThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBillDaThanhToan.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnBillDaThanhToan.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnBillDaThanhToan.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnBillDaThanhToan.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillDaThanhToan.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnBillDaThanhToan.Appearance.Options.UseBackColor = true;
            this.btnBillDaThanhToan.Appearance.Options.UseBorderColor = true;
            this.btnBillDaThanhToan.Appearance.Options.UseFont = true;
            this.btnBillDaThanhToan.Appearance.Options.UseForeColor = true;
            this.btnBillDaThanhToan.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnBillDaThanhToan.AppearanceHovered.BackColor2 = System.Drawing.Color.Gray;
            this.btnBillDaThanhToan.AppearanceHovered.BorderColor = System.Drawing.Color.Gray;
            this.btnBillDaThanhToan.AppearanceHovered.Options.UseBackColor = true;
            this.btnBillDaThanhToan.AppearanceHovered.Options.UseBorderColor = true;
            this.btnBillDaThanhToan.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBillDaThanhToan.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBillDaThanhToan.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBillDaThanhToan.AppearancePressed.Options.UseBackColor = true;
            this.btnBillDaThanhToan.AppearancePressed.Options.UseBorderColor = true;
            this.btnBillDaThanhToan.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnBillDaThanhToan.Image = global::QUANLYSHUSHI.Properties.Resources.MoneyRoi;
            this.btnBillDaThanhToan.Location = new System.Drawing.Point(278, 251);
            this.btnBillDaThanhToan.Name = "btnBillDaThanhToan";
            this.btnBillDaThanhToan.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnBillDaThanhToan.Size = new System.Drawing.Size(152, 38);
            this.btnBillDaThanhToan.TabIndex = 5;
            this.btnBillDaThanhToan.TabStop = false;
            this.btnBillDaThanhToan.Text = "Bill đã thanh toán";
            this.btnBillDaThanhToan.Click += new System.EventHandler(this.btnBillDaThanhToan_Click);
            // 
            // btnTatCaBill
            // 
            this.btnTatCaBill.AllowFocus = false;
            this.btnTatCaBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTatCaBill.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnTatCaBill.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnTatCaBill.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnTatCaBill.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTatCaBill.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnTatCaBill.Appearance.Options.UseBackColor = true;
            this.btnTatCaBill.Appearance.Options.UseBorderColor = true;
            this.btnTatCaBill.Appearance.Options.UseFont = true;
            this.btnTatCaBill.Appearance.Options.UseForeColor = true;
            this.btnTatCaBill.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnTatCaBill.AppearanceHovered.BackColor2 = System.Drawing.Color.Gray;
            this.btnTatCaBill.AppearanceHovered.BorderColor = System.Drawing.Color.Gray;
            this.btnTatCaBill.AppearanceHovered.Options.UseBackColor = true;
            this.btnTatCaBill.AppearanceHovered.Options.UseBorderColor = true;
            this.btnTatCaBill.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTatCaBill.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTatCaBill.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTatCaBill.AppearancePressed.Options.UseBackColor = true;
            this.btnTatCaBill.AppearancePressed.Options.UseBorderColor = true;
            this.btnTatCaBill.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnTatCaBill.Image = global::QUANLYSHUSHI.Properties.Resources.MoneyAll;
            this.btnTatCaBill.Location = new System.Drawing.Point(278, 295);
            this.btnTatCaBill.Name = "btnTatCaBill";
            this.btnTatCaBill.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnTatCaBill.Size = new System.Drawing.Size(152, 38);
            this.btnTatCaBill.TabIndex = 6;
            this.btnTatCaBill.TabStop = false;
            this.btnTatCaBill.Text = "Tất cả Bill";
            this.btnTatCaBill.Click += new System.EventHandler(this.btnTatCaBill_Click);
            // 
            // btnBillChuaThanhToan
            // 
            this.btnBillChuaThanhToan.AllowFocus = false;
            this.btnBillChuaThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBillChuaThanhToan.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnBillChuaThanhToan.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnBillChuaThanhToan.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnBillChuaThanhToan.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillChuaThanhToan.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnBillChuaThanhToan.Appearance.Options.UseBackColor = true;
            this.btnBillChuaThanhToan.Appearance.Options.UseBorderColor = true;
            this.btnBillChuaThanhToan.Appearance.Options.UseFont = true;
            this.btnBillChuaThanhToan.Appearance.Options.UseForeColor = true;
            this.btnBillChuaThanhToan.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnBillChuaThanhToan.AppearanceHovered.BackColor2 = System.Drawing.Color.Gray;
            this.btnBillChuaThanhToan.AppearanceHovered.BorderColor = System.Drawing.Color.Gray;
            this.btnBillChuaThanhToan.AppearanceHovered.Options.UseBackColor = true;
            this.btnBillChuaThanhToan.AppearanceHovered.Options.UseBorderColor = true;
            this.btnBillChuaThanhToan.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBillChuaThanhToan.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBillChuaThanhToan.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBillChuaThanhToan.AppearancePressed.Options.UseBackColor = true;
            this.btnBillChuaThanhToan.AppearancePressed.Options.UseBorderColor = true;
            this.btnBillChuaThanhToan.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnBillChuaThanhToan.Image = global::QUANLYSHUSHI.Properties.Resources.MoneyChua;
            this.btnBillChuaThanhToan.Location = new System.Drawing.Point(278, 207);
            this.btnBillChuaThanhToan.Name = "btnBillChuaThanhToan";
            this.btnBillChuaThanhToan.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnBillChuaThanhToan.Size = new System.Drawing.Size(152, 38);
            this.btnBillChuaThanhToan.TabIndex = 4;
            this.btnBillChuaThanhToan.TabStop = false;
            this.btnBillChuaThanhToan.Text = "Bill chưa thanh toán";
            this.btnBillChuaThanhToan.Click += new System.EventHandler(this.btnBillChuaThanhToan_Click);
            // 
            // UCBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.gcBill);
            this.Controls.Add(this.btnXuatExcelBill);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnBillDaThanhToan);
            this.Controls.Add(this.btnTatCaBill);
            this.Controls.Add(this.btnBillChuaThanhToan);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "UCBill";
            this.Size = new System.Drawing.Size(453, 425);
            ((System.ComponentModel.ISupportInitialize)(this.gcBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBill)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbSoBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBill.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcBill;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBill;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraEditors.SimpleButton btnXuatExcelBill;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.ComboBoxEdit cbbSoBan;
        private DevExpress.XtraEditors.TimeEdit timeBill;
        private System.Windows.Forms.DateTimePicker dtpTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnBillDaThanhToan;
        private DevExpress.XtraEditors.SimpleButton btnTatCaBill;
        private DevExpress.XtraEditors.SimpleButton btnBillChuaThanhToan;
    }
}
