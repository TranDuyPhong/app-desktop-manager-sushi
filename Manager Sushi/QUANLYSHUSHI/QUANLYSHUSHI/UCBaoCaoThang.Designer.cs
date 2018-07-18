namespace QUANLYSHUSHI
{
    partial class UCBaoCaoThang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCBaoCaoThang));
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.dtpTimKiemBaoCaoTheoThang = new System.Windows.Forms.DateTimePicker();
            this.gcBaoCaoThang = new DevExpress.XtraGrid.GridControl();
            this.gvBaoCaoThang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn25 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn26 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn27 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn28 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnTimKiemBaoCaoTheoThang = new DevExpress.XtraEditors.SimpleButton();
            this.btnXuatExcelThang = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcBaoCaoThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBaoCaoThang)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl20.Location = new System.Drawing.Point(162, 309);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(113, 15);
            this.labelControl20.TabIndex = 36;
            this.labelControl20.Text = "Tìm kiếm theo tháng";
            // 
            // dtpTimKiemBaoCaoTheoThang
            // 
            this.dtpTimKiemBaoCaoTheoThang.CustomFormat = "MM/yyyy";
            this.dtpTimKiemBaoCaoTheoThang.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTimKiemBaoCaoTheoThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimKiemBaoCaoTheoThang.Location = new System.Drawing.Point(281, 302);
            this.dtpTimKiemBaoCaoTheoThang.Name = "dtpTimKiemBaoCaoTheoThang";
            this.dtpTimKiemBaoCaoTheoThang.Size = new System.Drawing.Size(146, 22);
            this.dtpTimKiemBaoCaoTheoThang.TabIndex = 34;
            this.dtpTimKiemBaoCaoTheoThang.TabStop = false;
            // 
            // gcBaoCaoThang
            // 
            this.gcBaoCaoThang.Location = new System.Drawing.Point(24, 23);
            this.gcBaoCaoThang.MainView = this.gvBaoCaoThang;
            this.gcBaoCaoThang.Name = "gcBaoCaoThang";
            this.gcBaoCaoThang.Size = new System.Drawing.Size(403, 247);
            this.gcBaoCaoThang.TabIndex = 32;
            this.gcBaoCaoThang.TabStop = false;
            this.gcBaoCaoThang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBaoCaoThang});
            // 
            // gvBaoCaoThang
            // 
            this.gvBaoCaoThang.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gvBaoCaoThang.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gvBaoCaoThang.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gvBaoCaoThang.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvBaoCaoThang.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvBaoCaoThang.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gvBaoCaoThang.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gvBaoCaoThang.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gvBaoCaoThang.Appearance.Row.Options.UseBackColor = true;
            this.gvBaoCaoThang.Appearance.Row.Options.UseBorderColor = true;
            this.gvBaoCaoThang.Appearance.VertLine.BackColor = System.Drawing.Color.Black;
            this.gvBaoCaoThang.Appearance.VertLine.BackColor2 = System.Drawing.Color.Black;
            this.gvBaoCaoThang.Appearance.VertLine.BorderColor = System.Drawing.Color.Black;
            this.gvBaoCaoThang.Appearance.VertLine.Options.UseBackColor = true;
            this.gvBaoCaoThang.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvBaoCaoThang.Appearance.ViewCaption.BackColor = System.Drawing.Color.Blue;
            this.gvBaoCaoThang.Appearance.ViewCaption.BackColor2 = System.Drawing.Color.Blue;
            this.gvBaoCaoThang.Appearance.ViewCaption.BorderColor = System.Drawing.Color.Blue;
            this.gvBaoCaoThang.Appearance.ViewCaption.Options.UseBackColor = true;
            this.gvBaoCaoThang.Appearance.ViewCaption.Options.UseBorderColor = true;
            this.gvBaoCaoThang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn25,
            this.gridColumn26,
            this.gridColumn27,
            this.gridColumn28});
            this.gvBaoCaoThang.GridControl = this.gcBaoCaoThang;
            this.gvBaoCaoThang.Name = "gvBaoCaoThang";
            this.gvBaoCaoThang.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gvBaoCaoThang.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn25
            // 
            this.gridColumn25.Caption = "STT";
            this.gridColumn25.FieldName = "STT";
            this.gridColumn25.Name = "gridColumn25";
            this.gridColumn25.OptionsColumn.AllowEdit = false;
            this.gridColumn25.OptionsColumn.AllowFocus = false;
            this.gridColumn25.OptionsColumn.ReadOnly = true;
            this.gridColumn25.OptionsColumn.TabStop = false;
            this.gridColumn25.Visible = true;
            this.gridColumn25.VisibleIndex = 0;
            this.gridColumn25.Width = 50;
            // 
            // gridColumn26
            // 
            this.gridColumn26.Caption = "Món ăn";
            this.gridColumn26.FieldName = "Name";
            this.gridColumn26.Name = "gridColumn26";
            this.gridColumn26.OptionsColumn.AllowEdit = false;
            this.gridColumn26.OptionsColumn.AllowFocus = false;
            this.gridColumn26.OptionsColumn.ReadOnly = true;
            this.gridColumn26.OptionsColumn.TabStop = false;
            this.gridColumn26.Visible = true;
            this.gridColumn26.VisibleIndex = 1;
            this.gridColumn26.Width = 180;
            // 
            // gridColumn27
            // 
            this.gridColumn27.Caption = "Số lượng";
            this.gridColumn27.FieldName = "SoLuong";
            this.gridColumn27.Name = "gridColumn27";
            this.gridColumn27.OptionsColumn.AllowEdit = false;
            this.gridColumn27.OptionsColumn.AllowFocus = false;
            this.gridColumn27.OptionsColumn.ReadOnly = true;
            this.gridColumn27.OptionsColumn.TabStop = false;
            this.gridColumn27.Visible = true;
            this.gridColumn27.VisibleIndex = 2;
            this.gridColumn27.Width = 155;
            // 
            // gridColumn28
            // 
            this.gridColumn28.Caption = "Tổng tiền";
            this.gridColumn28.FieldName = "TongTien";
            this.gridColumn28.Name = "gridColumn28";
            this.gridColumn28.OptionsColumn.AllowEdit = false;
            this.gridColumn28.OptionsColumn.AllowFocus = false;
            this.gridColumn28.OptionsColumn.ReadOnly = true;
            this.gridColumn28.OptionsColumn.TabStop = false;
            this.gridColumn28.Visible = true;
            this.gridColumn28.VisibleIndex = 3;
            // 
            // btnTimKiemBaoCaoTheoThang
            // 
            this.btnTimKiemBaoCaoTheoThang.AllowFocus = false;
            this.btnTimKiemBaoCaoTheoThang.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnTimKiemBaoCaoTheoThang.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnTimKiemBaoCaoTheoThang.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnTimKiemBaoCaoTheoThang.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemBaoCaoTheoThang.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemBaoCaoTheoThang.Appearance.Options.UseBackColor = true;
            this.btnTimKiemBaoCaoTheoThang.Appearance.Options.UseBorderColor = true;
            this.btnTimKiemBaoCaoTheoThang.Appearance.Options.UseFont = true;
            this.btnTimKiemBaoCaoTheoThang.Appearance.Options.UseForeColor = true;
            this.btnTimKiemBaoCaoTheoThang.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnTimKiemBaoCaoTheoThang.AppearanceHovered.BackColor2 = System.Drawing.Color.Gray;
            this.btnTimKiemBaoCaoTheoThang.AppearanceHovered.BorderColor = System.Drawing.Color.Gray;
            this.btnTimKiemBaoCaoTheoThang.AppearanceHovered.Options.UseBackColor = true;
            this.btnTimKiemBaoCaoTheoThang.AppearanceHovered.Options.UseBorderColor = true;
            this.btnTimKiemBaoCaoTheoThang.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTimKiemBaoCaoTheoThang.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTimKiemBaoCaoTheoThang.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTimKiemBaoCaoTheoThang.AppearancePressed.Options.UseBackColor = true;
            this.btnTimKiemBaoCaoTheoThang.AppearancePressed.Options.UseBorderColor = true;
            this.btnTimKiemBaoCaoTheoThang.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnTimKiemBaoCaoTheoThang.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemBaoCaoTheoThang.Image")));
            this.btnTimKiemBaoCaoTheoThang.Location = new System.Drawing.Point(294, 330);
            this.btnTimKiemBaoCaoTheoThang.Name = "btnTimKiemBaoCaoTheoThang";
            this.btnTimKiemBaoCaoTheoThang.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnTimKiemBaoCaoTheoThang.Size = new System.Drawing.Size(121, 38);
            this.btnTimKiemBaoCaoTheoThang.TabIndex = 35;
            this.btnTimKiemBaoCaoTheoThang.TabStop = false;
            this.btnTimKiemBaoCaoTheoThang.Text = "Tìm kiếm";
            this.btnTimKiemBaoCaoTheoThang.Click += new System.EventHandler(this.btnTimKiemBaoCaoTheoThang_Click);
            // 
            // btnXuatExcelThang
            // 
            this.btnXuatExcelThang.AllowFocus = false;
            this.btnXuatExcelThang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXuatExcelThang.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnXuatExcelThang.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnXuatExcelThang.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnXuatExcelThang.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcelThang.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcelThang.Appearance.Options.UseBackColor = true;
            this.btnXuatExcelThang.Appearance.Options.UseBorderColor = true;
            this.btnXuatExcelThang.Appearance.Options.UseFont = true;
            this.btnXuatExcelThang.Appearance.Options.UseForeColor = true;
            this.btnXuatExcelThang.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnXuatExcelThang.AppearanceHovered.BackColor2 = System.Drawing.Color.Gray;
            this.btnXuatExcelThang.AppearanceHovered.BorderColor = System.Drawing.Color.Gray;
            this.btnXuatExcelThang.AppearanceHovered.Options.UseBackColor = true;
            this.btnXuatExcelThang.AppearanceHovered.Options.UseBorderColor = true;
            this.btnXuatExcelThang.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXuatExcelThang.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXuatExcelThang.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXuatExcelThang.AppearancePressed.Options.UseBackColor = true;
            this.btnXuatExcelThang.AppearancePressed.Options.UseBorderColor = true;
            this.btnXuatExcelThang.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnXuatExcelThang.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatExcelThang.Image")));
            this.btnXuatExcelThang.Location = new System.Drawing.Point(24, 286);
            this.btnXuatExcelThang.Name = "btnXuatExcelThang";
            this.btnXuatExcelThang.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnXuatExcelThang.Size = new System.Drawing.Size(132, 38);
            this.btnXuatExcelThang.TabIndex = 33;
            this.btnXuatExcelThang.TabStop = false;
            this.btnXuatExcelThang.Text = "Xuất ra Excel";
            this.btnXuatExcelThang.Click += new System.EventHandler(this.btnXuatExcelThang_Click);
            // 
            // UCBaoCaoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.labelControl20);
            this.Controls.Add(this.btnTimKiemBaoCaoTheoThang);
            this.Controls.Add(this.dtpTimKiemBaoCaoTheoThang);
            this.Controls.Add(this.btnXuatExcelThang);
            this.Controls.Add(this.gcBaoCaoThang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCBaoCaoThang";
            this.Size = new System.Drawing.Size(453, 425);
            ((System.ComponentModel.ISupportInitialize)(this.gcBaoCaoThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBaoCaoThang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.SimpleButton btnTimKiemBaoCaoTheoThang;
        private System.Windows.Forms.DateTimePicker dtpTimKiemBaoCaoTheoThang;
        private DevExpress.XtraEditors.SimpleButton btnXuatExcelThang;
        private DevExpress.XtraGrid.GridControl gcBaoCaoThang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBaoCaoThang;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn25;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn26;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn27;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn28;
    }
}
