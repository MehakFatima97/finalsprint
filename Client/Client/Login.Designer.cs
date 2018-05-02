namespace Client
{
    partial class Login
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
            this.txtCNIC = new System.Windows.Forms.TextBox();
            this.lblCNIC = new System.Windows.Forms.Label();
            this.linklblResetPassword = new System.Windows.Forms.LinkLabel();
            this.cmdLogin = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.linklblRegistration = new System.Windows.Forms.LinkLabel();
            this.linklblDoctorinfo = new System.Windows.Forms.LinkLabel();
            this.linklblHistory = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtCNIC
            // 
            this.txtCNIC.Location = new System.Drawing.Point(296, 41);
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(100, 20);
            this.txtCNIC.TabIndex = 0;
            this.txtCNIC.TextChanged += new System.EventHandler(this.txtCNIC_TextChanged);
            // 
            // lblCNIC
            // 
            this.lblCNIC.AutoSize = true;
            this.lblCNIC.Location = new System.Drawing.Point(85, 41);
            this.lblCNIC.Name = "lblCNIC";
            this.lblCNIC.Size = new System.Drawing.Size(32, 13);
            this.lblCNIC.TabIndex = 1;
            this.lblCNIC.Text = "CNIC";
            // 
            // linklblResetPassword
            // 
            this.linklblResetPassword.AutoSize = true;
            this.linklblResetPassword.Location = new System.Drawing.Point(46, 213);
            this.linklblResetPassword.Name = "linklblResetPassword";
            this.linklblResetPassword.Size = new System.Drawing.Size(84, 13);
            this.linklblResetPassword.TabIndex = 2;
            this.linklblResetPassword.TabStop = true;
            this.linklblResetPassword.Text = "Reset Password";
            this.linklblResetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblResetPassword_LinkClicked);
            // 
            // cmdLogin
            // 
            this.cmdLogin.Location = new System.Drawing.Point(441, 226);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(75, 23);
            this.cmdLogin.TabIndex = 3;
            this.cmdLogin.Text = "Login";
            this.cmdLogin.UseVisualStyleBackColor = true;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(85, 89);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(296, 91);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 0;
            // 
            // linklblRegistration
            // 
            this.linklblRegistration.AutoSize = true;
            this.linklblRegistration.Location = new System.Drawing.Point(46, 255);
            this.linklblRegistration.Name = "linklblRegistration";
            this.linklblRegistration.Size = new System.Drawing.Size(63, 13);
            this.linklblRegistration.TabIndex = 2;
            this.linklblRegistration.TabStop = true;
            this.linklblRegistration.Text = "Registration";
            this.linklblRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblRegistration_LinkClicked);
            // 
            // linklblDoctorinfo
            // 
            this.linklblDoctorinfo.AutoSize = true;
            this.linklblDoctorinfo.Location = new System.Drawing.Point(522, 26);
            this.linklblDoctorinfo.Name = "linklblDoctorinfo";
            this.linklblDoctorinfo.Size = new System.Drawing.Size(59, 13);
            this.linklblDoctorinfo.TabIndex = 4;
            this.linklblDoctorinfo.TabStop = true;
            this.linklblDoctorinfo.Text = "Doctor info";
            this.linklblDoctorinfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblDoctorinfo_LinkClicked);
            // 
            // linklblHistory
            // 
            this.linklblHistory.AutoSize = true;
            this.linklblHistory.Location = new System.Drawing.Point(526, 69);
            this.linklblHistory.Name = "linklblHistory";
            this.linklblHistory.Size = new System.Drawing.Size(39, 13);
            this.linklblHistory.TabIndex = 5;
            this.linklblHistory.TabStop = true;
            this.linklblHistory.Text = "History";
            this.linklblHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblHistory_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 310);
            this.Controls.Add(this.linklblHistory);
            this.Controls.Add(this.linklblDoctorinfo);
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.linklblRegistration);
            this.Controls.Add(this.linklblResetPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblCNIC);
            this.Controls.Add(this.txtCNIC);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCNIC;
        private System.Windows.Forms.Label lblCNIC;
        private System.Windows.Forms.LinkLabel linklblResetPassword;
        private System.Windows.Forms.Button cmdLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.LinkLabel linklblRegistration;
        private System.Windows.Forms.LinkLabel linklblDoctorinfo;
        private System.Windows.Forms.LinkLabel linklblHistory;
    }
}