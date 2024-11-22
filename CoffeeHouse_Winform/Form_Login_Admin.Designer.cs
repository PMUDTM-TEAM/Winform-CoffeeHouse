namespace CoffeeHouse_Winform
{
    partial class Form_Login_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login_Admin));
            this.panelLogin = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelLogin.CausesValidation = false;
            this.panelLogin.Controls.Add(this.lblTitle);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.guna2PictureBox1);
            this.panelLogin.Controls.Add(this.txtPassword);
            this.panelLogin.Controls.Add(this.txtEmail);
            this.panelLogin.Controls.Add(this.lblLogin);
            this.panelLogin.Controls.Add(this.lblUsername);
            this.panelLogin.Controls.Add(this.lblPassword);
            this.panelLogin.FillColor = System.Drawing.Color.White;
            this.panelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panelLogin.Location = new System.Drawing.Point(131, 51);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.ShadowColor = System.Drawing.Color.Black;
            this.panelLogin.Size = new System.Drawing.Size(1006, 723);
            this.panelLogin.TabIndex = 9;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(15, 77);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(478, 52);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Quản lý quán cà phê";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(131)))), ((int)(((byte)(103)))));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(39, 419);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(416, 58);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Đăng nhập tài khoản";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(547, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(509, 732);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(131)))), ((int)(((byte)(103)))));
            this.txtPassword.BorderRadius = 12;
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "12345678";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(39, 314);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPassword.PlaceholderText = "Nhập mật khẩu";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(416, 48);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.TextOffset = new System.Drawing.Point(6, 0);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(131)))), ((int)(((byte)(103)))));
            this.txtEmail.BorderRadius = 12;
            this.txtEmail.BorderThickness = 2;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "Dien12@gmail.com";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(39, 207);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtEmail.PlaceholderText = "Nhập vào mã quản lý của bạn";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(416, 48);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.TextOffset = new System.Drawing.Point(6, 0);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(158, 77);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(193, 39);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Đăng nhập";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(36, 186);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(112, 24);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Mã Quản Lý";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(36, 293);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 24);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // Form_Login_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 826);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Login_Admin";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel panelLogin;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
    }
}

