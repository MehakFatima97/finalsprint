namespace Client
{
    partial class LoginD
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmdLogin = new System.Windows.Forms.Button();
            this.linklblRegistration = new System.Windows.Forms.LinkLabel();
            this.txtCNIC = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtHospitalName = new System.Windows.Forms.TextBox();
            this.lblCNIC = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblHospitalName = new System.Windows.Forms.Label();
            this.linklblResetPassword = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(55, 51);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(342, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmdLogin
            // 
            this.cmdLogin.Location = new System.Drawing.Point(605, 251);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(75, 23);
            this.cmdLogin.TabIndex = 2;
            this.cmdLogin.Text = "Login";
            this.cmdLogin.UseVisualStyleBackColor = true;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // linklblRegistration
            // 
            this.linklblRegistration.AutoSize = true;
            this.linklblRegistration.Location = new System.Drawing.Point(35, 274);
            this.linklblRegistration.Name = "linklblRegistration";
            this.linklblRegistration.Size = new System.Drawing.Size(63, 13);
            this.linklblRegistration.TabIndex = 3;
            this.linklblRegistration.TabStop = true;
            this.linklblRegistration.Text = "Registration";
            // 
            // txtCNIC
            // 
            this.txtCNIC.Location = new System.Drawing.Point(342, 92);
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(100, 20);
            this.txtCNIC.TabIndex = 1;
            this.txtCNIC.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(342, 130);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtHospitalName
            // 
            this.txtHospitalName.Location = new System.Drawing.Point(342, 172);
            this.txtHospitalName.Name = "txtHospitalName";
            this.txtHospitalName.Size = new System.Drawing.Size(100, 20);
            this.txtHospitalName.TabIndex = 1;
            this.txtHospitalName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCNIC
            // 
            this.lblCNIC.AutoSize = true;
            this.lblCNIC.Location = new System.Drawing.Point(55, 92);
            this.lblCNIC.Name = "lblCNIC";
            this.lblCNIC.Size = new System.Drawing.Size(32, 13);
            this.lblCNIC.TabIndex = 0;
            this.lblCNIC.Text = "CNIC";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(55, 137);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password";
            // 
            // lblHospitalName
            // 
            this.lblHospitalName.AutoSize = true;
            this.lblHospitalName.Location = new System.Drawing.Point(55, 175);
            this.lblHospitalName.Name = "lblHospitalName";
            this.lblHospitalName.Size = new System.Drawing.Size(76, 13);
            this.lblHospitalName.TabIndex = 0;
            this.lblHospitalName.Text = "Hospital Name";
            // 
            // linklblResetPassword
            // 
            this.linklblResetPassword.AutoSize = true;
            this.linklblResetPassword.Location = new System.Drawing.Point(35, 233);
            this.linklblResetPassword.Name = "linklblResetPassword";
            this.linklblResetPassword.Size = new System.Drawing.Size(84, 13);
            this.linklblResetPassword.TabIndex = 3;
            this.linklblResetPassword.TabStop = true;
            this.linklblResetPassword.Text = "Reset Password";
            this.linklblResetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblResetPassword_LinkClicked);
            // 
            // LoginD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 307);
            this.Controls.Add(this.linklblResetPassword);
            this.Controls.Add(this.linklblRegistration);
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.txtHospitalName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtCNIC);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblHospitalName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblCNIC);
            this.Controls.Add(this.lblName);
            this.Name = "LoginD";
            this.Text = "LoginD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button cmdLogin;
        private System.Windows.Forms.LinkLabel linklblRegistration;
        private System.Windows.Forms.TextBox txtCNIC;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtHospitalName;
        private System.Windows.Forms.Label lblCNIC;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblHospitalName;
        private System.Windows.Forms.LinkLabel linklblResetPassword;
    }
}