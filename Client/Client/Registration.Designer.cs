namespace Client
{
    partial class Registration
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCNIC = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblHospitalName = new System.Windows.Forms.Label();
            this.txtCNIC = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtHospitalName = new System.Windows.Forms.TextBox();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.linklblLogin = new System.Windows.Forms.LinkLabel();
            this.radioButtonPatient = new System.Windows.Forms.RadioButton();
            this.radioButtonDoctor = new System.Windows.Forms.RadioButton();
            this.cmdRegister = new System.Windows.Forms.Button();
            this.radioButtonLAdmin = new System.Windows.Forms.RadioButton();
            this.radioButtonLDoctor = new System.Windows.Forms.RadioButton();
            this.radioButtonLPatient = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(428, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(71, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblCNIC
            // 
            this.lblCNIC.AutoSize = true;
            this.lblCNIC.Location = new System.Drawing.Point(71, 108);
            this.lblCNIC.Name = "lblCNIC";
            this.lblCNIC.Size = new System.Drawing.Size(32, 13);
            this.lblCNIC.TabIndex = 1;
            this.lblCNIC.Text = "CNIC";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(71, 159);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblHospitalName
            // 
            this.lblHospitalName.AutoSize = true;
            this.lblHospitalName.Location = new System.Drawing.Point(71, 252);
            this.lblHospitalName.Name = "lblHospitalName";
            this.lblHospitalName.Size = new System.Drawing.Size(76, 13);
            this.lblHospitalName.TabIndex = 1;
            this.lblHospitalName.Text = "Hospital Name";
            // 
            // txtCNIC
            // 
            this.txtCNIC.Location = new System.Drawing.Point(428, 106);
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(100, 20);
            this.txtCNIC.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(428, 156);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 0;
            // 
            // txtHospitalName
            // 
            this.txtHospitalName.Location = new System.Drawing.Point(428, 265);
            this.txtHospitalName.Name = "txtHospitalName";
            this.txtHospitalName.Size = new System.Drawing.Size(100, 20);
            this.txtHospitalName.TabIndex = 0;
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Location = new System.Drawing.Point(57, 12);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(54, 17);
            this.radioButtonAdmin.TabIndex = 2;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Admin";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // linklblLogin
            // 
            this.linklblLogin.AutoSize = true;
            this.linklblLogin.Location = new System.Drawing.Point(71, 326);
            this.linklblLogin.Name = "linklblLogin";
            this.linklblLogin.Size = new System.Drawing.Size(33, 13);
            this.linklblLogin.TabIndex = 3;
            this.linklblLogin.TabStop = true;
            this.linklblLogin.Text = "Login";
            this.linklblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblLogin_LinkClicked);
            // 
            // radioButtonPatient
            // 
            this.radioButtonPatient.AutoSize = true;
            this.radioButtonPatient.Location = new System.Drawing.Point(262, 12);
            this.radioButtonPatient.Name = "radioButtonPatient";
            this.radioButtonPatient.Size = new System.Drawing.Size(58, 17);
            this.radioButtonPatient.TabIndex = 2;
            this.radioButtonPatient.TabStop = true;
            this.radioButtonPatient.Text = "Patient";
            this.radioButtonPatient.UseVisualStyleBackColor = true;
            // 
            // radioButtonDoctor
            // 
            this.radioButtonDoctor.AutoSize = true;
            this.radioButtonDoctor.Location = new System.Drawing.Point(57, 209);
            this.radioButtonDoctor.Name = "radioButtonDoctor";
            this.radioButtonDoctor.Size = new System.Drawing.Size(57, 17);
            this.radioButtonDoctor.TabIndex = 2;
            this.radioButtonDoctor.TabStop = true;
            this.radioButtonDoctor.Text = "Doctor";
            this.radioButtonDoctor.UseVisualStyleBackColor = true;
            // 
            // cmdRegister
            // 
            this.cmdRegister.Location = new System.Drawing.Point(659, 326);
            this.cmdRegister.Name = "cmdRegister";
            this.cmdRegister.Size = new System.Drawing.Size(75, 23);
            this.cmdRegister.TabIndex = 4;
            this.cmdRegister.Text = "Register";
            this.cmdRegister.UseVisualStyleBackColor = true;
            this.cmdRegister.Click += new System.EventHandler(this.cmdRegister_Click);
            // 
            // radioButtonLAdmin
            // 
            this.radioButtonLAdmin.AutoSize = true;
            this.radioButtonLAdmin.Location = new System.Drawing.Point(74, 356);
            this.radioButtonLAdmin.Name = "radioButtonLAdmin";
            this.radioButtonLAdmin.Size = new System.Drawing.Size(60, 17);
            this.radioButtonLAdmin.TabIndex = 5;
            this.radioButtonLAdmin.TabStop = true;
            this.radioButtonLAdmin.Text = "LAdmin";
            this.radioButtonLAdmin.UseVisualStyleBackColor = true;
            this.radioButtonLAdmin.CheckedChanged += new System.EventHandler(this.radioButtonLAdmin_CheckedChanged);
            // 
            // radioButtonLDoctor
            // 
            this.radioButtonLDoctor.AutoSize = true;
            this.radioButtonLDoctor.Location = new System.Drawing.Point(74, 379);
            this.radioButtonLDoctor.Name = "radioButtonLDoctor";
            this.radioButtonLDoctor.Size = new System.Drawing.Size(63, 17);
            this.radioButtonLDoctor.TabIndex = 5;
            this.radioButtonLDoctor.TabStop = true;
            this.radioButtonLDoctor.Text = "LDoctor";
            this.radioButtonLDoctor.UseVisualStyleBackColor = true;
            this.radioButtonLDoctor.CheckedChanged += new System.EventHandler(this.radioButtonLDoctor_CheckedChanged);
            // 
            // radioButtonLPatient
            // 
            this.radioButtonLPatient.AutoSize = true;
            this.radioButtonLPatient.Location = new System.Drawing.Point(74, 402);
            this.radioButtonLPatient.Name = "radioButtonLPatient";
            this.radioButtonLPatient.Size = new System.Drawing.Size(64, 17);
            this.radioButtonLPatient.TabIndex = 5;
            this.radioButtonLPatient.TabStop = true;
            this.radioButtonLPatient.Text = "LPatient";
            this.radioButtonLPatient.UseVisualStyleBackColor = true;
            this.radioButtonLPatient.CheckedChanged += new System.EventHandler(this.radioButtonLPatient_CheckedChanged);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 443);
            this.Controls.Add(this.radioButtonLPatient);
            this.Controls.Add(this.radioButtonLDoctor);
            this.Controls.Add(this.radioButtonLAdmin);
            this.Controls.Add(this.cmdRegister);
            this.Controls.Add(this.linklblLogin);
            this.Controls.Add(this.radioButtonDoctor);
            this.Controls.Add(this.radioButtonPatient);
            this.Controls.Add(this.radioButtonAdmin);
            this.Controls.Add(this.lblHospitalName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblCNIC);
            this.Controls.Add(this.txtHospitalName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtCNIC);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Name = "Registration";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCNIC;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblHospitalName;
        private System.Windows.Forms.TextBox txtCNIC;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtHospitalName;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
        private System.Windows.Forms.LinkLabel linklblLogin;
        private System.Windows.Forms.RadioButton radioButtonPatient;
        private System.Windows.Forms.RadioButton radioButtonDoctor;
        private System.Windows.Forms.Button cmdRegister;
        private System.Windows.Forms.RadioButton radioButtonLAdmin;
        private System.Windows.Forms.RadioButton radioButtonLDoctor;
        private System.Windows.Forms.RadioButton radioButtonLPatient;
    }
}

