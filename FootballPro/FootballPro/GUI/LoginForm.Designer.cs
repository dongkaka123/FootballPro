using System.Windows.Forms;

namespace FootballPro
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lblLogin = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblHiden = new System.Windows.Forms.Label();
            this.lblFogetPassword = new System.Windows.Forms.Label();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.Font = new System.Drawing.Font("Paytone One", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lblLogin.Location = new System.Drawing.Point(149, 279);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(460, 109);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Đăng nhập";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(80)))));
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.lblUserName);
            this.pnlLogin.Controls.Add(this.txbPassword);
            this.pnlLogin.Controls.Add(this.txbUserName);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.pbLogo);
            this.pnlLogin.Controls.Add(this.lblExit);
            this.pnlLogin.Controls.Add(this.lblHiden);
            this.pnlLogin.Controls.Add(this.lblFogetPassword);
            this.pnlLogin.Controls.Add(this.lblLogin);
            this.pnlLogin.Location = new System.Drawing.Point(0, -2);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(765, 994);
            this.pnlLogin.TabIndex = 1;
            this.pnlLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlLogin_MouseDown);
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Paytone One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lblPassword.Location = new System.Drawing.Point(33, 565);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(194, 62);
            this.lblPassword.TabIndex = 27;
            this.lblPassword.Text = "Password :";
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Paytone One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lblUserName.Location = new System.Drawing.Point(33, 471);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(194, 62);
            this.lblUserName.TabIndex = 26;
            this.lblUserName.Text = "User Name : ";
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPassword.Font = new System.Drawing.Font("Paytone One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.txbPassword.Location = new System.Drawing.Point(236, 565);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(471, 40);
            this.txbPassword.TabIndex = 1;
            this.txbPassword.Click += new System.EventHandler(this.txbPassword_Click);
            // 
            // txbUserName
            // 
            this.txbUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.txbUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbUserName.Font = new System.Drawing.Font("Paytone One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.txbUserName.Location = new System.Drawing.Point(236, 477);
            this.txbUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(471, 40);
            this.txbUserName.TabIndex = 0;
            this.txbUserName.Click += new System.EventHandler(this.txbUserName_Click);
            this.txbUserName.TextChanged += new System.EventHandler(this.txbUserName_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(170)))), ((int)(((byte)(242)))));
            this.btnLogin.Font = new System.Drawing.Font("Paytone One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.btnLogin.Location = new System.Drawing.Point(257, 743);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(248, 65);
            this.btnLogin.TabIndex = 21;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(80)))));
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(257, 47);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(231, 215);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 20;
            this.pbLogo.TabStop = false;
            this.pbLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlLogin_MouseDown);
            // 
            // lblExit
            // 
            this.lblExit.Font = new System.Drawing.Font("Paytone One", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblExit.Location = new System.Drawing.Point(708, -22);
            this.lblExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(46, 74);
            this.lblExit.TabIndex = 15;
            this.lblExit.Text = "x";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblHiden
            // 
            this.lblHiden.Font = new System.Drawing.Font("Paytone One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHiden.ForeColor = System.Drawing.Color.White;
            this.lblHiden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHiden.Location = new System.Drawing.Point(627, -15);
            this.lblHiden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHiden.Name = "lblHiden";
            this.lblHiden.Size = new System.Drawing.Size(63, 60);
            this.lblHiden.TabIndex = 14;
            this.lblHiden.Text = "—";
            this.lblHiden.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHiden.Click += new System.EventHandler(this.lblHiden_Click);
            // 
            // lblFogetPassword
            // 
            this.lblFogetPassword.AutoSize = true;
            this.lblFogetPassword.Font = new System.Drawing.Font("Paytone One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFogetPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.lblFogetPassword.Location = new System.Drawing.Point(489, 649);
            this.lblFogetPassword.Name = "lblFogetPassword";
            this.lblFogetPassword.Size = new System.Drawing.Size(215, 38);
            this.lblFogetPassword.TabIndex = 4;
            this.lblFogetPassword.Text = "Quên mật khẩu?";
            this.lblFogetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFogetPassword.Click += new System.EventHandler(this.lblFogetPassword_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 983);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblFogetPassword;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblHiden;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnLogin;
        private TextBox txbUserName;
        private TextBox txbPassword;
        private Label lblPassword;
        private Label lblUserName;
    }
}