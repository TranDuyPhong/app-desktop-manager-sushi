namespace QUANLYSHUSHI
{
    partial class UCDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDoanhThu));
            this.txtTongDoanhThu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.gcDoanhThu = new DevExpress.XtraGrid.GridControl();
            this.gvDoanhThu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXuatExcelDoanhThu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongDoanhThu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTongDoanhThu
            // 
            this.txtTongDoanhThu.Location = new System.Drawing.Point(256, 352);
            this.txtTongDoanhThu.Name = "txtTongDoanhThu";
            this.txtTongDoanhThu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongDoanhThu.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtTongDoanhThu.Properties.Appearance.Options.UseFont = true;
            this.txtTongDoanhThu.Properties.Appearance.Options.UseForeColor = true;
            this.txtTongDoanhThu.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtTongDoanhThu.Properties.ReadOnly = true;
            this.txtTongDoanhThu.Size = new System.Drawing.Size(171, 24);
            this.txtTongDoanhThu.TabIndex = 31;
            this.txtTongDoanhThu.TabStop = false;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl8.Location = new System.Drawing.Point(162, 360);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(88, 16);
            this.labelControl8.TabIndex = 30;
            this.labelControl8.Text = "Tổng doanh thu";
            // 
            // gcDoanhThu
            // 
            this.gcDoanhThu.Location = new System.Drawing.Point(24, 23);
            this.gcDoanhThu.MainView = this.gvDoanhThu;
            this.gcDoanhThu.Name = "gcDoanhThu";
            this.gcDoanhThu.Size = new System.Drawing.Size(403, 303);
            this.gcDoanhThu.TabIndex = 28;
            this.gcDoanhThu.TabStop = false;
            this.gcDoanhThu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDoanhThu});
            // 
            // gvDoanhThu
            // 
            this.gvDoanhThu.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gvDoanhThu.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gvDoanhThu.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gvDoanhThu.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvDoanhThu.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvDoanhThu.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gvDoanhThu.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gvDoanhThu.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gvDoanhThu.Appearance.Row.Options.UseBackColor = true;
            this.gvDoanhThu.Appearance.Row.Options.UseBorderColor = true;
            this.gvDoanhThu.Appearance.VertLine.BackColor = System.Drawing.Color.Black;
            this.gvDoanhThu.Appearance.VertLine.BackColor2 = System.Drawing.Color.Black;
            this.gvDoanhThu.Appearance.VertLine.BorderColor = System.Drawing.Color.Black;
            this.gvDoanhThu.Appearance.VertLine.Options.UseBackColor = true;
            this.gvDoanhThu.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvDoanhThu.Appearance.ViewCaption.BackColor = System.Drawing.Color.Blue;
            this.gvDoanhThu.Appearance.ViewCaption.BackColor2 = System.Drawing.Color.Blue;
            this.gvDoanhThu.Appearance.ViewCaption.BorderColor = System.Drawing.Color.Blue;
            this.gvDoanhThu.Appearance.ViewCaption.Options.UseBackColor = true;
            this.gvDoanhThu.Appearance.ViewCaption.Options.UseBorderColor = true;
            this.gvDoanhThu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn18,
            this.gridColumn19,
            this.gridColumn20});
            this.gvDoanhThu.GridControl = this.gcDoanhThu;
            this.gvDoanhThu.Name = "gvDoanhThu";
            this.gvDoanhThu.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gvDoanhThu.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "STT";
            this.gridColumn18.FieldName = "STT";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.OptionsColumn.AllowEdit = false;
            this.gridColumn18.OptionsColumn.AllowFocus = false;
            this.gridColumn18.OptionsColumn.ReadOnly = true;
            this.gridColumn18.OptionsColumn.TabStop = false;
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 0;
            this.gridColumn18.Width = 50;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "Ngày";
            this.gridColumn19.FieldName = "Ngay";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.OptionsColumn.AllowEdit = false;
            this.gridColumn19.OptionsColumn.AllowFocus = false;
            this.gridColumn19.OptionsColumn.ReadOnly = true;
            this.gridColumn19.OptionsColumn.TabStop = false;
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 1;
            this.gridColumn19.Width = 180;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "Tổng tiền";
            this.gridColumn20.FieldName = "TongTien";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.OptionsColumn.AllowEdit = false;
            this.gridColumn20.OptionsColumn.AllowFocus = false;
            this.gridColumn20.OptionsColumn.ReadOnly = true;
            this.gridColumn20.OptionsColumn.TabStop = false;
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 2;
            this.gridColumn20.Width = 155;
            // 
            // btnXuatExcelDoanhThu
            // 
            this.btnXuatExcelDoanhThu.AllowFocus = false;
            this.btnXuatExcelDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXuatExcelDoanhThu.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnXuatExcelDoanhThu.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnXuatExcelDoanhThu.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnXuatExcelDoanhThu.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcelDoanhThu.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcelDoanhThu.Appearance.Options.UseBackColor = true;
            this.btnXuatExcelDoanhThu.Appearance.Options.UseBorderColor = true;
            this.btnXuatExcelDoanhThu.Appearance.Options.UseFont = true;
            this.btnXuatExcelDoanhThu.Appearance.Options.UseForeColor = true;
            this.btnXuatExcelDoanhThu.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnXuatExcelDoanhThu.AppearanceHovered.BackColor2 = System.Drawing.Color.Gray;
            this.btnXuatExcelDoanhThu.AppearanceHovered.BorderColor = System.Drawing.Color.Gray;
            this.btnXuatExcelDoanhThu.AppearanceHovered.Options.UseBackColor = true;
            this.btnXuatExcelDoanhThu.AppearanceHovered.Options.UseBorderColor = true;
            this.btnXuatExcelDoanhThu.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXuatExcelDoanhThu.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXuatExcelDoanhThu.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXuatExcelDoanhThu.AppearancePressed.Options.UseBackColor = true;
            this.btnXuatExcelDoanhThu.AppearancePressed.Options.UseBorderColor = true;
            this.btnXuatExcelDoanhThu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnXuatExcelDoanhThu.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatExcelDoanhThu.Image")));
            this.btnXuatExcelDoanhThu.Location = new System.Drawing.Point(24, 338);
            this.btnXuatExcelDoanhThu.Name = "btnXuatExcelDoanhThu";
            this.btnXuatExcelDoanhThu.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnXuatExcelDoanhThu.Size = new System.Drawing.Size(132, 38);
            this.btnXuatExcelDoanhThu.TabIndex = 29;
            this.btnXuatExcelDoanhThu.TabStop = false;
            this.btnXuatExcelDoanhThu.Text = "Xuất ra Excel";
            this.btnXuatExcelDoanhThu.Click += new System.EventHandler(this.btnXuatExcelDoanhThu_Click);
            // 
            // UCDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.txtTongDoanhThu);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.btnXuatExcelDoanhThu);
            this.Controls.Add(this.gcDoanhThu);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UCDoanhThu";
            this.Size = new System.Drawing.Size(453, 425);
            ((System.ComponentModel.ISupportInitialize)(this.txtTongDoanhThu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtTongDoanhThu;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btnXuatExcelDoanhThu;
        private DevExpress.XtraGrid.GridControl gcDoanhThu;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDoanhThu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
    }
}
