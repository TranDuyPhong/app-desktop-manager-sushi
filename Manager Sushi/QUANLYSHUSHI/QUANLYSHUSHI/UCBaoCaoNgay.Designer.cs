namespace QUANLYSHUSHI
{
    partial class UCBaoCaoNgay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCBaoCaoNgay));
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.dtpTimKiemBaoCaoNgay = new System.Windows.Forms.DateTimePicker();
            this.gcBaoCaoNgay = new DevExpress.XtraGrid.GridControl();
            this.gvBaoCaoNgay = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnTimKiemBaoCaoNgay = new DevExpress.XtraEditors.SimpleButton();
            this.btnXuatExcelNgay = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcBaoCaoNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBaoCaoNgay)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl19.Location = new System.Drawing.Point(162, 307);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(108, 15);
            this.labelControl19.TabIndex = 33;
            this.labelControl19.Text = "Tìm kiếm theo ngày";
            // 
            // dtpTimKiemBaoCaoNgay
            // 
            this.dtpTimKiemBaoCaoNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTimKiemBaoCaoNgay.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTimKiemBaoCaoNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimKiemBaoCaoNgay.Location = new System.Drawing.Point(276, 300);
            this.dtpTimKiemBaoCaoNgay.Name = "dtpTimKiemBaoCaoNgay";
            this.dtpTimKiemBaoCaoNgay.Size = new System.Drawing.Size(151, 22);
            this.dtpTimKiemBaoCaoNgay.TabIndex = 29;
            this.dtpTimKiemBaoCaoNgay.TabStop = false;
            // 
            // gcBaoCaoNgay
            // 
            this.gcBaoCaoNgay.Location = new System.Drawing.Point(24, 21);
            this.gcBaoCaoNgay.MainView = this.gvBaoCaoNgay;
            this.gcBaoCaoNgay.Name = "gcBaoCaoNgay";
            this.gcBaoCaoNgay.Size = new System.Drawing.Size(403, 247);
            this.gcBaoCaoNgay.TabIndex = 30;
            this.gcBaoCaoNgay.TabStop = false;
            this.gcBaoCaoNgay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBaoCaoNgay});
            // 
            // gvBaoCaoNgay
            // 
            this.gvBaoCaoNgay.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gvBaoCaoNgay.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gvBaoCaoNgay.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gvBaoCaoNgay.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvBaoCaoNgay.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvBaoCaoNgay.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gvBaoCaoNgay.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gvBaoCaoNgay.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gvBaoCaoNgay.Appearance.Row.Options.UseBackColor = true;
            this.gvBaoCaoNgay.Appearance.Row.Options.UseBorderColor = true;
            this.gvBaoCaoNgay.Appearance.VertLine.BackColor = System.Drawing.Color.Black;
            this.gvBaoCaoNgay.Appearance.VertLine.BackColor2 = System.Drawing.Color.Black;
            this.gvBaoCaoNgay.Appearance.VertLine.BorderColor = System.Drawing.Color.Black;
            this.gvBaoCaoNgay.Appearance.VertLine.Options.UseBackColor = true;
            this.gvBaoCaoNgay.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvBaoCaoNgay.Appearance.ViewCaption.BackColor = System.Drawing.Color.Blue;
            this.gvBaoCaoNgay.Appearance.ViewCaption.BackColor2 = System.Drawing.Color.Blue;
            this.gvBaoCaoNgay.Appearance.ViewCaption.BorderColor = System.Drawing.Color.Blue;
            this.gvBaoCaoNgay.Appearance.ViewCaption.Options.UseBackColor = true;
            this.gvBaoCaoNgay.Appearance.ViewCaption.Options.UseBorderColor = true;
            this.gvBaoCaoNgay.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn21,
            this.gridColumn22,
            this.gridColumn23,
            this.gridColumn24});
            this.gvBaoCaoNgay.GridControl = this.gcBaoCaoNgay;
            this.gvBaoCaoNgay.Name = "gvBaoCaoNgay";
            this.gvBaoCaoNgay.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gvBaoCaoNgay.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "STT";
            this.gridColumn21.FieldName = "STT";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.OptionsColumn.AllowEdit = false;
            this.gridColumn21.OptionsColumn.AllowFocus = false;
            this.gridColumn21.OptionsColumn.ReadOnly = true;
            this.gridColumn21.OptionsColumn.TabStop = false;
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 0;
            this.gridColumn21.Width = 50;
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "Món ăn";
            this.gridColumn22.FieldName = "Name";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.OptionsColumn.AllowEdit = false;
            this.gridColumn22.OptionsColumn.AllowFocus = false;
            this.gridColumn22.OptionsColumn.ReadOnly = true;
            this.gridColumn22.OptionsColumn.TabStop = false;
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 1;
            this.gridColumn22.Width = 180;
            // 
            // gridColumn23
            // 
            this.gridColumn23.Caption = "Số lượng";
            this.gridColumn23.FieldName = "SoLuong";
            this.gridColumn23.Name = "gridColumn23";
            this.gridColumn23.OptionsColumn.AllowEdit = false;
            this.gridColumn23.OptionsColumn.AllowFocus = false;
            this.gridColumn23.OptionsColumn.ReadOnly = true;
            this.gridColumn23.OptionsColumn.TabStop = false;
            this.gridColumn23.Visible = true;
            this.gridColumn23.VisibleIndex = 2;
            this.gridColumn23.Width = 155;
            // 
            // gridColumn24
            // 
            this.gridColumn24.Caption = "Tổng tiền";
            this.gridColumn24.FieldName = "TongTien";
            this.gridColumn24.Name = "gridColumn24";
            this.gridColumn24.OptionsColumn.AllowEdit = false;
            this.gridColumn24.OptionsColumn.AllowFocus = false;
            this.gridColumn24.OptionsColumn.ReadOnly = true;
            this.gridColumn24.OptionsColumn.TabStop = false;
            this.gridColumn24.Visible = true;
            this.gridColumn24.VisibleIndex = 3;
            // 
            // btnTimKiemBaoCaoNgay
            // 
            this.btnTimKiemBaoCaoNgay.AllowFocus = false;
            this.btnTimKiemBaoCaoNgay.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnTimKiemBaoCaoNgay.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnTimKiemBaoCaoNgay.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnTimKiemBaoCaoNgay.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemBaoCaoNgay.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemBaoCaoNgay.Appearance.Options.UseBackColor = true;
            this.btnTimKiemBaoCaoNgay.Appearance.Options.UseBorderColor = true;
            this.btnTimKiemBaoCaoNgay.Appearance.Options.UseFont = true;
            this.btnTimKiemBaoCaoNgay.Appearance.Options.UseForeColor = true;
            this.btnTimKiemBaoCaoNgay.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnTimKiemBaoCaoNgay.AppearanceHovered.BackColor2 = System.Drawing.Color.Gray;
            this.btnTimKiemBaoCaoNgay.AppearanceHovered.BorderColor = System.Drawing.Color.Gray;
            this.btnTimKiemBaoCaoNgay.AppearanceHovered.Options.UseBackColor = true;
            this.btnTimKiemBaoCaoNgay.AppearanceHovered.Options.UseBorderColor = true;
            this.btnTimKiemBaoCaoNgay.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTimKiemBaoCaoNgay.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTimKiemBaoCaoNgay.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTimKiemBaoCaoNgay.AppearancePressed.Options.UseBackColor = true;
            this.btnTimKiemBaoCaoNgay.AppearancePressed.Options.UseBorderColor = true;
            this.btnTimKiemBaoCaoNgay.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnTimKiemBaoCaoNgay.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemBaoCaoNgay.Image")));
            this.btnTimKiemBaoCaoNgay.Location = new System.Drawing.Point(289, 328);
            this.btnTimKiemBaoCaoNgay.Name = "btnTimKiemBaoCaoNgay";
            this.btnTimKiemBaoCaoNgay.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnTimKiemBaoCaoNgay.Size = new System.Drawing.Size(121, 38);
            this.btnTimKiemBaoCaoNgay.TabIndex = 32;
            this.btnTimKiemBaoCaoNgay.TabStop = false;
            this.btnTimKiemBaoCaoNgay.Text = "Tìm kiếm";
            this.btnTimKiemBaoCaoNgay.Click += new System.EventHandler(this.btnTimKiemBaoCaoNgay_Click);
            // 
            // btnXuatExcelNgay
            // 
            this.btnXuatExcelNgay.AllowFocus = false;
            this.btnXuatExcelNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXuatExcelNgay.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnXuatExcelNgay.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnXuatExcelNgay.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnXuatExcelNgay.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcelNgay.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcelNgay.Appearance.Options.UseBackColor = true;
            this.btnXuatExcelNgay.Appearance.Options.UseBorderColor = true;
            this.btnXuatExcelNgay.Appearance.Options.UseFont = true;
            this.btnXuatExcelNgay.Appearance.Options.UseForeColor = true;
            this.btnXuatExcelNgay.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnXuatExcelNgay.AppearanceHovered.BackColor2 = System.Drawing.Color.Gray;
            this.btnXuatExcelNgay.AppearanceHovered.BorderColor = System.Drawing.Color.Gray;
            this.btnXuatExcelNgay.AppearanceHovered.Options.UseBackColor = true;
            this.btnXuatExcelNgay.AppearanceHovered.Options.UseBorderColor = true;
            this.btnXuatExcelNgay.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXuatExcelNgay.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXuatExcelNgay.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXuatExcelNgay.AppearancePressed.Options.UseBackColor = true;
            this.btnXuatExcelNgay.AppearancePressed.Options.UseBorderColor = true;
            this.btnXuatExcelNgay.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnXuatExcelNgay.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatExcelNgay.Image")));
            this.btnXuatExcelNgay.Location = new System.Drawing.Point(24, 284);
            this.btnXuatExcelNgay.Name = "btnXuatExcelNgay";
            this.btnXuatExcelNgay.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnXuatExcelNgay.Size = new System.Drawing.Size(132, 38);
            this.btnXuatExcelNgay.TabIndex = 31;
            this.btnXuatExcelNgay.TabStop = false;
            this.btnXuatExcelNgay.Text = "Xuất ra Excel";
            this.btnXuatExcelNgay.Click += new System.EventHandler(this.btnXuatExcelNgay_Click);
            // 
            // UCBaoCaoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.labelControl19);
            this.Controls.Add(this.btnTimKiemBaoCaoNgay);
            this.Controls.Add(this.dtpTimKiemBaoCaoNgay);
            this.Controls.Add(this.btnXuatExcelNgay);
            this.Controls.Add(this.gcBaoCaoNgay);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "UCBaoCaoNgay";
            this.Size = new System.Drawing.Size(453, 425);
            ((System.ComponentModel.ISupportInitialize)(this.gcBaoCaoNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBaoCaoNgay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.SimpleButton btnTimKiemBaoCaoNgay;
        private System.Windows.Forms.DateTimePicker dtpTimKiemBaoCaoNgay;
        private DevExpress.XtraEditors.SimpleButton btnXuatExcelNgay;
        private DevExpress.XtraGrid.GridControl gcBaoCaoNgay;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBaoCaoNgay;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
    }
}
