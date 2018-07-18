namespace QUANLYSHUSHI
{
    partial class UCMonAn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMonAn));
            this.txtTimKiemMonAn = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gcMonAn = new DevExpress.XtraGrid.GridControl();
            this.gvMonAn = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtGia = new DevExpress.XtraEditors.TextEdit();
            this.txtTenThucAn = new DevExpress.XtraEditors.TextEdit();
            this.btnQuayLaiThucAn = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaMon = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaMon = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemMon = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiemMonAn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenThucAn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiemMonAn
            // 
            this.txtTimKiemMonAn.Location = new System.Drawing.Point(180, 19);
            this.txtTimKiemMonAn.Name = "txtTimKiemMonAn";
            this.txtTimKiemMonAn.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTimKiemMonAn.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemMonAn.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiemMonAn.Properties.Appearance.Options.UseBackColor = true;
            this.txtTimKiemMonAn.Properties.Appearance.Options.UseFont = true;
            this.txtTimKiemMonAn.Properties.Appearance.Options.UseForeColor = true;
            this.txtTimKiemMonAn.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtTimKiemMonAn.Size = new System.Drawing.Size(251, 24);
            this.txtTimKiemMonAn.TabIndex = 2;
            this.txtTimKiemMonAn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiemMonAn_KeyDown);
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Location = new System.Drawing.Point(78, 27);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(96, 16);
            this.labelControl15.TabIndex = 44;
            this.labelControl15.Text = "Tìm kiếm món ăn";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(23, 311);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(19, 15);
            this.labelControl4.TabIndex = 43;
            this.labelControl4.Text = "Giá";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(23, 272);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 15);
            this.labelControl3.TabIndex = 42;
            this.labelControl3.Text = "Tên món ăn";
            // 
            // gcMonAn
            // 
            this.gcMonAn.Location = new System.Drawing.Point(23, 50);
            this.gcMonAn.MainView = this.gvMonAn;
            this.gcMonAn.Name = "gcMonAn";
            this.gcMonAn.Size = new System.Drawing.Size(408, 200);
            this.gcMonAn.TabIndex = 36;
            this.gcMonAn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMonAn,
            this.gridView4});
            // 
            // gvMonAn
            // 
            this.gvMonAn.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gvMonAn.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gvMonAn.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gvMonAn.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvMonAn.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvMonAn.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvMonAn.Appearance.Row.BackColor2 = System.Drawing.Color.White;
            this.gvMonAn.Appearance.Row.BorderColor = System.Drawing.Color.White;
            this.gvMonAn.Appearance.Row.Options.UseBackColor = true;
            this.gvMonAn.Appearance.Row.Options.UseBorderColor = true;
            this.gvMonAn.Appearance.VertLine.BackColor = System.Drawing.Color.Black;
            this.gvMonAn.Appearance.VertLine.BackColor2 = System.Drawing.Color.Black;
            this.gvMonAn.Appearance.VertLine.BorderColor = System.Drawing.Color.Black;
            this.gvMonAn.Appearance.VertLine.Options.UseBackColor = true;
            this.gvMonAn.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvMonAn.Appearance.ViewCaption.BackColor = System.Drawing.Color.MidnightBlue;
            this.gvMonAn.Appearance.ViewCaption.BackColor2 = System.Drawing.Color.MidnightBlue;
            this.gvMonAn.Appearance.ViewCaption.BorderColor = System.Drawing.Color.MidnightBlue;
            this.gvMonAn.Appearance.ViewCaption.Options.UseBackColor = true;
            this.gvMonAn.Appearance.ViewCaption.Options.UseBorderColor = true;
            this.gvMonAn.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn16,
            this.gridColumn4,
            this.gridColumn5});
            this.gvMonAn.GridControl = this.gcMonAn;
            this.gvMonAn.Name = "gvMonAn";
            this.gvMonAn.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gvMonAn.OptionsSelection.MultiSelect = true;
            this.gvMonAn.OptionsView.ShowGroupPanel = false;
            this.gvMonAn.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvMonAn_FocusedRowChanged);
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Mã";
            this.gridColumn16.FieldName = "ID";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.OptionsColumn.AllowEdit = false;
            this.gridColumn16.OptionsColumn.AllowFocus = false;
            this.gridColumn16.OptionsColumn.ReadOnly = true;
            this.gridColumn16.OptionsColumn.TabStop = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tên món ăn";
            this.gridColumn4.FieldName = "Name";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.OptionsColumn.TabStop = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Giá";
            this.gridColumn5.FieldName = "Price";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowFocus = false;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.OptionsColumn.TabStop = false;
            this.gridColumn5.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.gcMonAn;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(113, 302);
            this.txtGia.Name = "txtGia";
            this.txtGia.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtGia.Properties.Appearance.Options.UseFont = true;
            this.txtGia.Properties.Appearance.Options.UseForeColor = true;
            this.txtGia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtGia.Size = new System.Drawing.Size(121, 24);
            this.txtGia.TabIndex = 1;
            // 
            // txtTenThucAn
            // 
            this.txtTenThucAn.Location = new System.Drawing.Point(113, 263);
            this.txtTenThucAn.Name = "txtTenThucAn";
            this.txtTenThucAn.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenThucAn.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtTenThucAn.Properties.Appearance.Options.UseFont = true;
            this.txtTenThucAn.Properties.Appearance.Options.UseForeColor = true;
            this.txtTenThucAn.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtTenThucAn.Size = new System.Drawing.Size(198, 24);
            this.txtTenThucAn.TabIndex = 0;
            // 
            // btnQuayLaiThucAn
            // 
            this.btnQuayLaiThucAn.AllowFocus = false;
            this.btnQuayLaiThucAn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQuayLaiThucAn.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQuayLaiThucAn.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQuayLaiThucAn.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLaiThucAn.Appearance.Options.UseBackColor = true;
            this.btnQuayLaiThucAn.Appearance.Options.UseBorderColor = true;
            this.btnQuayLaiThucAn.Appearance.Options.UseFont = true;
            this.btnQuayLaiThucAn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnQuayLaiThucAn.Image = ((System.Drawing.Image)(resources.GetObject("btnQuayLaiThucAn.Image")));
            this.btnQuayLaiThucAn.Location = new System.Drawing.Point(23, 16);
            this.btnQuayLaiThucAn.Name = "btnQuayLaiThucAn";
            this.btnQuayLaiThucAn.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnQuayLaiThucAn.Size = new System.Drawing.Size(40, 27);
            this.btnQuayLaiThucAn.TabIndex = 6;
            this.btnQuayLaiThucAn.TabStop = false;
            this.btnQuayLaiThucAn.Click += new System.EventHandler(this.btnQuayLaiThucAn_Click);
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.AllowFocus = false;
            this.btnXoaMon.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnXoaMon.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnXoaMon.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnXoaMon.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMon.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnXoaMon.Appearance.Options.UseBackColor = true;
            this.btnXoaMon.Appearance.Options.UseBorderColor = true;
            this.btnXoaMon.Appearance.Options.UseFont = true;
            this.btnXoaMon.Appearance.Options.UseForeColor = true;
            this.btnXoaMon.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnXoaMon.AppearanceHovered.BackColor2 = System.Drawing.Color.Gray;
            this.btnXoaMon.AppearanceHovered.BorderColor = System.Drawing.Color.Gray;
            this.btnXoaMon.AppearanceHovered.Options.UseBackColor = true;
            this.btnXoaMon.AppearanceHovered.Options.UseBorderColor = true;
            this.btnXoaMon.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXoaMon.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXoaMon.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXoaMon.AppearancePressed.Options.UseBackColor = true;
            this.btnXoaMon.AppearancePressed.Options.UseBorderColor = true;
            this.btnXoaMon.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnXoaMon.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaMon.Image")));
            this.btnXoaMon.Location = new System.Drawing.Point(297, 373);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnXoaMon.Size = new System.Drawing.Size(134, 32);
            this.btnXoaMon.TabIndex = 4;
            this.btnXoaMon.TabStop = false;
            this.btnXoaMon.Text = "Xóa món ăn";
            this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // btnSuaMon
            // 
            this.btnSuaMon.AllowFocus = false;
            this.btnSuaMon.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnSuaMon.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnSuaMon.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnSuaMon.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaMon.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSuaMon.Appearance.Options.UseBackColor = true;
            this.btnSuaMon.Appearance.Options.UseBorderColor = true;
            this.btnSuaMon.Appearance.Options.UseFont = true;
            this.btnSuaMon.Appearance.Options.UseForeColor = true;
            this.btnSuaMon.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnSuaMon.AppearanceHovered.BackColor2 = System.Drawing.Color.Gray;
            this.btnSuaMon.AppearanceHovered.BorderColor = System.Drawing.Color.Gray;
            this.btnSuaMon.AppearanceHovered.Options.UseBackColor = true;
            this.btnSuaMon.AppearanceHovered.Options.UseBorderColor = true;
            this.btnSuaMon.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSuaMon.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSuaMon.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSuaMon.AppearancePressed.Options.UseBackColor = true;
            this.btnSuaMon.AppearancePressed.Options.UseBorderColor = true;
            this.btnSuaMon.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSuaMon.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaMon.Image")));
            this.btnSuaMon.Location = new System.Drawing.Point(297, 335);
            this.btnSuaMon.Name = "btnSuaMon";
            this.btnSuaMon.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnSuaMon.Size = new System.Drawing.Size(134, 32);
            this.btnSuaMon.TabIndex = 3;
            this.btnSuaMon.TabStop = false;
            this.btnSuaMon.Text = "Sửa món ăn";
            this.btnSuaMon.Click += new System.EventHandler(this.btnSuaMon_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.AllowFocus = false;
            this.btnThemMon.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnThemMon.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnThemMon.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnThemMon.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnThemMon.Appearance.Options.UseBackColor = true;
            this.btnThemMon.Appearance.Options.UseBorderColor = true;
            this.btnThemMon.Appearance.Options.UseFont = true;
            this.btnThemMon.Appearance.Options.UseForeColor = true;
            this.btnThemMon.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnThemMon.AppearanceHovered.BackColor2 = System.Drawing.Color.Gray;
            this.btnThemMon.AppearanceHovered.BorderColor = System.Drawing.Color.Gray;
            this.btnThemMon.AppearanceHovered.Options.UseBackColor = true;
            this.btnThemMon.AppearanceHovered.Options.UseBorderColor = true;
            this.btnThemMon.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThemMon.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThemMon.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThemMon.AppearancePressed.Options.UseBackColor = true;
            this.btnThemMon.AppearancePressed.Options.UseBorderColor = true;
            this.btnThemMon.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnThemMon.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMon.Image")));
            this.btnThemMon.Location = new System.Drawing.Point(297, 297);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnThemMon.Size = new System.Drawing.Size(134, 32);
            this.btnThemMon.TabIndex = 2;
            this.btnThemMon.TabStop = false;
            this.btnThemMon.Text = "Thêm món ăn";
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UCMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnQuayLaiThucAn);
            this.Controls.Add(this.txtTimKiemMonAn);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.gcMonAn);
            this.Controls.Add(this.btnXoaMon);
            this.Controls.Add(this.btnSuaMon);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTenThucAn);
            this.Controls.Add(this.btnThemMon);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "UCMonAn";
            this.Size = new System.Drawing.Size(453, 425);
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiemMonAn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenThucAn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnQuayLaiThucAn;
        private DevExpress.XtraEditors.TextEdit txtTimKiemMonAn;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl gcMonAn;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMonAn;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.SimpleButton btnXoaMon;
        private DevExpress.XtraEditors.SimpleButton btnSuaMon;
        private DevExpress.XtraEditors.TextEdit txtGia;
        private DevExpress.XtraEditors.TextEdit txtTenThucAn;
        private DevExpress.XtraEditors.SimpleButton btnThemMon;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
