namespace QUANLYSHUSHI
{
    partial class fLoginSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLoginSystem));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnTitle = new System.Windows.Forms.Panel();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.btnTab = new DevExpress.XtraEditors.SimpleButton();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.btnShowPassword = new DevExpress.XtraEditors.SimpleButton();
            this.btnChangePassword = new DevExpress.XtraEditors.SimpleButton();
            this.btnForgetPassword = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Phần Mềm Quản Lý Shushi by ndbTeam";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(93, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(309, 30);
            this.pnTitle.TabIndex = 1;
            this.pnTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnTitle_Paint);
            this.pnTitle.DoubleClick += new System.EventHandler(this.pnTitle_DoubleClick);
            this.pnTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTitle_MouseDown);
            this.pnTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnTitle_MouseMove);
            // 
            // txtPassword
            // 
            this.txtPassword.EditValue = "";
            this.txtPassword.Location = new System.Drawing.Point(82, 207);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Properties.Appearance.Options.UseBackColor = true;
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.Appearance.Options.UseForeColor = true;
            this.txtPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtPassword.Size = new System.Drawing.Size(159, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Click += new System.EventHandler(this.txtClick);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            // 
            // txtUsername
            // 
            this.txtUsername.EditValue = "";
            this.txtUsername.Location = new System.Drawing.Point(83, 149);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtUsername.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Properties.Appearance.Options.UseBackColor = true;
            this.txtUsername.Properties.Appearance.Options.UseFont = true;
            this.txtUsername.Properties.Appearance.Options.UseForeColor = true;
            this.txtUsername.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtUsername.Size = new System.Drawing.Size(159, 20);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Click += new System.EventHandler(this.txtClick);
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            // 
            // btnTab
            // 
            this.btnTab.AllowFocus = false;
            this.btnTab.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnTab.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.btnTab.Appearance.BorderColor = System.Drawing.Color.Black;
            this.btnTab.Appearance.Options.UseBackColor = true;
            this.btnTab.Appearance.Options.UseBorderColor = true;
            this.btnTab.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnTab.Location = new System.Drawing.Point(0, 142);
            this.btnTab.Name = "btnTab";
            this.btnTab.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnTab.Size = new System.Drawing.Size(10, 34);
            this.btnTab.TabIndex = 1;
            this.btnTab.TabStop = false;
            // 
            // separatorControl1
            // 
            this.separatorControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.separatorControl1.Location = new System.Drawing.Point(62, 164);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(203, 26);
            this.separatorControl1.TabIndex = 8;
            // 
            // separatorControl2
            // 
            this.separatorControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.separatorControl2.Location = new System.Drawing.Point(62, 222);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(203, 26);
            this.separatorControl2.TabIndex = 9;
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogin.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogin.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogin.Appearance.Options.UseBackColor = true;
            this.btnLogin.Appearance.Options.UseBorderColor = true;
            this.btnLogin.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.btnLogin.AppearanceHovered.BorderColor = System.Drawing.Color.White;
            this.btnLogin.AppearanceHovered.Options.UseBackColor = true;
            this.btnLogin.AppearanceHovered.Options.UseBorderColor = true;
            this.btnLogin.AppearancePressed.BackColor = System.Drawing.Color.White;
            this.btnLogin.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.AppearancePressed.BorderColor = System.Drawing.Color.White;
            this.btnLogin.AppearancePressed.Options.UseBackColor = true;
            this.btnLogin.AppearancePressed.Options.UseBorderColor = true;
            this.btnLogin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnLogin.Image = global::QUANLYSHUSHI.Properties.Resources.Next4;
            this.btnLogin.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(201, 254);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnLogin.Size = new System.Drawing.Size(64, 53);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.Enter += new System.EventHandler(this.btnLogin_Enter);
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.AllowFocus = false;
            this.btnShowPassword.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnShowPassword.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnShowPassword.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnShowPassword.Appearance.Options.UseBackColor = true;
            this.btnShowPassword.Appearance.Options.UseBorderColor = true;
            this.btnShowPassword.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPassword.Image")));
            this.btnShowPassword.Location = new System.Drawing.Point(247, 205);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnShowPassword.Size = new System.Drawing.Size(19, 23);
            this.btnShowPassword.TabIndex = 6;
            this.btnShowPassword.TabStop = false;
            this.btnShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShowPassword_MouseDown);
            this.btnShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnShowPassword_MouseUp);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnChangePassword.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnChangePassword.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnChangePassword.Appearance.Options.UseBackColor = true;
            this.btnChangePassword.Appearance.Options.UseBorderColor = true;
            this.btnChangePassword.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChangePassword.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.btnChangePassword.AppearanceHovered.BorderColor = System.Drawing.Color.White;
            this.btnChangePassword.AppearanceHovered.Options.UseBackColor = true;
            this.btnChangePassword.AppearanceHovered.Options.UseBorderColor = true;
            this.btnChangePassword.AppearancePressed.BackColor = System.Drawing.Color.White;
            this.btnChangePassword.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChangePassword.AppearancePressed.BorderColor = System.Drawing.Color.White;
            this.btnChangePassword.AppearancePressed.Options.UseBackColor = true;
            this.btnChangePassword.AppearancePressed.Options.UseBorderColor = true;
            this.btnChangePassword.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnChangePassword.Image = global::QUANLYSHUSHI.Properties.Resources.ChangePassword1;
            this.btnChangePassword.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnChangePassword.Location = new System.Drawing.Point(121, 254);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnChangePassword.Size = new System.Drawing.Size(64, 53);
            this.btnChangePassword.TabIndex = 3;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            this.btnChangePassword.Enter += new System.EventHandler(this.btnChangePassword_Enter);
            // 
            // btnForgetPassword
            // 
            this.btnForgetPassword.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnForgetPassword.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnForgetPassword.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnForgetPassword.Appearance.Options.UseBackColor = true;
            this.btnForgetPassword.Appearance.Options.UseBorderColor = true;
            this.btnForgetPassword.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnForgetPassword.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.btnForgetPassword.AppearanceHovered.BorderColor = System.Drawing.Color.White;
            this.btnForgetPassword.AppearanceHovered.Options.UseBackColor = true;
            this.btnForgetPassword.AppearanceHovered.Options.UseBorderColor = true;
            this.btnForgetPassword.AppearancePressed.BackColor = System.Drawing.Color.White;
            this.btnForgetPassword.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnForgetPassword.AppearancePressed.BorderColor = System.Drawing.Color.White;
            this.btnForgetPassword.AppearancePressed.Options.UseBackColor = true;
            this.btnForgetPassword.AppearancePressed.Options.UseBorderColor = true;
            this.btnForgetPassword.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnForgetPassword.Image = global::QUANLYSHUSHI.Properties.Resources.ForgetPassword;
            this.btnForgetPassword.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnForgetPassword.Location = new System.Drawing.Point(41, 254);
            this.btnForgetPassword.Name = "btnForgetPassword";
            this.btnForgetPassword.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnForgetPassword.Size = new System.Drawing.Size(64, 53);
            this.btnForgetPassword.TabIndex = 4;
            this.btnForgetPassword.Click += new System.EventHandler(this.btnForgetPassword_Click);
            this.btnForgetPassword.Enter += new System.EventHandler(this.btnForgetPassword_Enter);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(102, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(104, 36);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "LOGIN";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(62, 130);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 15);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Username";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(62, 190);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 15);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Password";
            // 
            // fLoginSystem
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(309, 325);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.separatorControl2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.btnTab);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnForgetPassword);
            this.Controls.Add(this.pnTitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "fLoginSystem";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fLoginSystem_KeyDown);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pnTitle;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.SimpleButton btnForgetPassword;
        private DevExpress.XtraEditors.SimpleButton btnChangePassword;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.SimpleButton btnTab;
        private DevExpress.XtraEditors.SimpleButton btnShowPassword;
        public DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;


    }
}

