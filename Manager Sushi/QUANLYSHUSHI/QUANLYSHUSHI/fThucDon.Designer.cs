namespace QUANLYSHUSHI
{
    partial class fThucDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThucDon));
            this.pnTitle = new System.Windows.Forms.Panel();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.lbMonAn = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbThucDonHienTai = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnRight = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbThucDonHienTai)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnTitle.Controls.Add(this.btnClose);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(396, 30);
            this.pnTitle.TabIndex = 2;
            this.pnTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnTitle_Paint);
            // 
            // btnClose
            // 
            this.btnClose.AllowFocus = false;
            this.btnClose.Appearance.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnClose.Appearance.BackColor2 = System.Drawing.Color.MidnightBlue;
            this.btnClose.Appearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnClose.Appearance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnClose.Appearance.Options.UseBackColor = true;
            this.btnClose.Appearance.Options.UseBorderColor = true;
            this.btnClose.Appearance.Options.UseForeColor = true;
            this.btnClose.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.btnClose.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.btnClose.AppearanceHovered.BorderColor = System.Drawing.Color.White;
            this.btnClose.AppearanceHovered.Options.UseBackColor = true;
            this.btnClose.AppearanceHovered.Options.UseBorderColor = true;
            this.btnClose.AppearancePressed.BackColor = System.Drawing.Color.Gray;
            this.btnClose.AppearancePressed.BackColor2 = System.Drawing.Color.Gray;
            this.btnClose.AppearancePressed.BorderColor = System.Drawing.Color.Gray;
            this.btnClose.AppearancePressed.Options.UseBackColor = true;
            this.btnClose.AppearancePressed.Options.UseBorderColor = true;
            this.btnClose.BackgroundImage = global::QUANLYSHUSHI.Properties.Resources.Close;
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::QUANLYSHUSHI.Properties.Resources.Close;
            this.btnClose.Location = new System.Drawing.Point(366, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnClose.Size = new System.Drawing.Size(28, 28);
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbMonAn
            // 
            this.lbMonAn.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.lbMonAn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbMonAn.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbMonAn.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbMonAn.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonAn.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lbMonAn.Appearance.Options.UseBackColor = true;
            this.lbMonAn.Appearance.Options.UseBorderColor = true;
            this.lbMonAn.Appearance.Options.UseFont = true;
            this.lbMonAn.Appearance.Options.UseForeColor = true;
            this.lbMonAn.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lbMonAn.HorizontalScrollbar = true;
            this.lbMonAn.Location = new System.Drawing.Point(0, 64);
            this.lbMonAn.Name = "lbMonAn";
            this.lbMonAn.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbMonAn.ShowFocusRect = false;
            this.lbMonAn.Size = new System.Drawing.Size(169, 183);
            this.lbMonAn.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Location = new System.Drawing.Point(68, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 15);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Món ăn";
            // 
            // lbThucDonHienTai
            // 
            this.lbThucDonHienTai.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.lbThucDonHienTai.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbThucDonHienTai.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbThucDonHienTai.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbThucDonHienTai.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThucDonHienTai.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lbThucDonHienTai.Appearance.Options.UseBackColor = true;
            this.lbThucDonHienTai.Appearance.Options.UseBorderColor = true;
            this.lbThucDonHienTai.Appearance.Options.UseFont = true;
            this.lbThucDonHienTai.Appearance.Options.UseForeColor = true;
            this.lbThucDonHienTai.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lbThucDonHienTai.HorizontalScrollbar = true;
            this.lbThucDonHienTai.Location = new System.Drawing.Point(225, 64);
            this.lbThucDonHienTai.Name = "lbThucDonHienTai";
            this.lbThucDonHienTai.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbThucDonHienTai.ShowFocusRect = false;
            this.lbThucDonHienTai.Size = new System.Drawing.Size(171, 183);
            this.lbThucDonHienTai.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Location = new System.Drawing.Point(254, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 15);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Thực đơn hiện tại";
            // 
            // btnRemove
            // 
            this.btnRemove.AllowFocus = false;
            this.btnRemove.Appearance.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRemove.Appearance.BackColor2 = System.Drawing.Color.MidnightBlue;
            this.btnRemove.Appearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnRemove.Appearance.Options.UseBackColor = true;
            this.btnRemove.Appearance.Options.UseBorderColor = true;
            this.btnRemove.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnRemove.AppearanceHovered.BackColor2 = System.Drawing.Color.Gray;
            this.btnRemove.AppearanceHovered.BorderColor = System.Drawing.Color.Gray;
            this.btnRemove.AppearanceHovered.Options.UseBackColor = true;
            this.btnRemove.AppearanceHovered.Options.UseBorderColor = true;
            this.btnRemove.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRemove.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRemove.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRemove.AppearancePressed.Options.UseBackColor = true;
            this.btnRemove.AppearancePressed.Options.UseBorderColor = true;
            this.btnRemove.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.Location = new System.Drawing.Point(175, 134);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnRemove.Size = new System.Drawing.Size(42, 38);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.TabStop = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRight
            // 
            this.btnRight.AllowFocus = false;
            this.btnRight.Appearance.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRight.Appearance.BackColor2 = System.Drawing.Color.MidnightBlue;
            this.btnRight.Appearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnRight.Appearance.Options.UseBackColor = true;
            this.btnRight.Appearance.Options.UseBorderColor = true;
            this.btnRight.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnRight.AppearanceHovered.BackColor2 = System.Drawing.Color.Gray;
            this.btnRight.AppearanceHovered.BorderColor = System.Drawing.Color.Gray;
            this.btnRight.AppearanceHovered.Options.UseBackColor = true;
            this.btnRight.AppearanceHovered.Options.UseBorderColor = true;
            this.btnRight.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRight.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRight.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRight.AppearancePressed.Options.UseBackColor = true;
            this.btnRight.AppearancePressed.Options.UseBorderColor = true;
            this.btnRight.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnRight.Image = ((System.Drawing.Image)(resources.GetObject("btnRight.Image")));
            this.btnRight.Location = new System.Drawing.Point(175, 90);
            this.btnRight.Name = "btnRight";
            this.btnRight.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnRight.Size = new System.Drawing.Size(42, 38);
            this.btnRight.TabIndex = 0;
            this.btnRight.TabStop = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnOk
            // 
            this.btnOk.AllowFocus = false;
            this.btnOk.Appearance.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnOk.Appearance.BackColor2 = System.Drawing.Color.MidnightBlue;
            this.btnOk.Appearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnOk.Appearance.Options.UseBackColor = true;
            this.btnOk.Appearance.Options.UseBorderColor = true;
            this.btnOk.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnOk.AppearanceHovered.BackColor2 = System.Drawing.Color.Gray;
            this.btnOk.AppearanceHovered.BorderColor = System.Drawing.Color.Gray;
            this.btnOk.AppearanceHovered.Options.UseBackColor = true;
            this.btnOk.AppearanceHovered.Options.UseBorderColor = true;
            this.btnOk.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnOk.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnOk.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnOk.AppearancePressed.Options.UseBackColor = true;
            this.btnOk.AppearancePressed.Options.UseBorderColor = true;
            this.btnOk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.Location = new System.Drawing.Point(175, 197);
            this.btnOk.Name = "btnOk";
            this.btnOk.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnOk.Size = new System.Drawing.Size(42, 38);
            this.btnOk.TabIndex = 2;
            this.btnOk.TabStop = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // fThucDon
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(396, 247);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lbThucDonHienTai);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lbMonAn);
            this.Controls.Add(this.pnTitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fThucDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fThucDon";
            this.Load += new System.EventHandler(this.fThucDon_Load);
            this.pnTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbThucDonHienTai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.ListBoxControl lbMonAn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ListBoxControl lbThucDonHienTai;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.SimpleButton btnRight;
        private DevExpress.XtraEditors.SimpleButton btnOk;

    }
}