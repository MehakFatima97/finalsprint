namespace Client
{
    partial class PatientHistory
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
            this.lblCNIC = new System.Windows.Forms.Label();
            this.cmdLogout = new System.Windows.Forms.Button();
            this.cmdupdate = new System.Windows.Forms.Button();
            this.cmdNewPatient = new System.Windows.Forms.Button();
            this.linklblShowHistory = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gv6 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHospitalName = new System.Windows.Forms.Label();
            this.lblHospital = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtmedicines = new System.Windows.Forms.TextBox();
            this.txtdisease = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblMedicines = new System.Windows.Forms.Label();
            this.lblDisease = new System.Windows.Forms.Label();
            this.cmdAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv6)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCNIC
            // 
            this.lblCNIC.AutoSize = true;
            this.lblCNIC.Location = new System.Drawing.Point(335, 78);
            this.lblCNIC.Name = "lblCNIC";
            this.lblCNIC.Size = new System.Drawing.Size(0, 13);
            this.lblCNIC.TabIndex = 0;
            this.lblCNIC.Click += new System.EventHandler(this.lblCNIC_Click);
            // 
            // cmdLogout
            // 
            this.cmdLogout.Location = new System.Drawing.Point(23, 388);
            this.cmdLogout.Name = "cmdLogout";
            this.cmdLogout.Size = new System.Drawing.Size(75, 23);
            this.cmdLogout.TabIndex = 2;
            this.cmdLogout.Text = "Logout";
            this.cmdLogout.UseVisualStyleBackColor = true;
            this.cmdLogout.Click += new System.EventHandler(this.cmdLogout_Click);
            // 
            // cmdupdate
            // 
            this.cmdupdate.Location = new System.Drawing.Point(50, 325);
            this.cmdupdate.Name = "cmdupdate";
            this.cmdupdate.Size = new System.Drawing.Size(75, 23);
            this.cmdupdate.TabIndex = 2;
            this.cmdupdate.Text = "Update";
            this.cmdupdate.UseVisualStyleBackColor = true;
            this.cmdupdate.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdNewPatient
            // 
            this.cmdNewPatient.Location = new System.Drawing.Point(638, 388);
            this.cmdNewPatient.Name = "cmdNewPatient";
            this.cmdNewPatient.Size = new System.Drawing.Size(75, 23);
            this.cmdNewPatient.TabIndex = 2;
            this.cmdNewPatient.Text = "New Patient";
            this.cmdNewPatient.UseVisualStyleBackColor = true;
            this.cmdNewPatient.Click += new System.EventHandler(this.cmdNewPatient_Click);
            // 
            // linklblShowHistory
            // 
            this.linklblShowHistory.AutoSize = true;
            this.linklblShowHistory.Location = new System.Drawing.Point(614, 87);
            this.linklblShowHistory.Name = "linklblShowHistory";
            this.linklblShowHistory.Size = new System.Drawing.Size(69, 13);
            this.linklblShowHistory.TabIndex = 4;
            this.linklblShowHistory.TabStop = true;
            this.linklblShowHistory.Text = "Show History";
            this.linklblShowHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblShowHistory_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "CNIC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // gv6
            // 
            this.gv6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv6.Location = new System.Drawing.Point(393, 134);
            this.gv6.Name = "gv6";
            this.gv6.Size = new System.Drawing.Size(290, 234);
            this.gv6.TabIndex = 7;
            this.gv6.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv6_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Doctor Name";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(488, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 9;
            // 
            // lblHospitalName
            // 
            this.lblHospitalName.AutoSize = true;
            this.lblHospitalName.Location = new System.Drawing.Point(344, 19);
            this.lblHospitalName.Name = "lblHospitalName";
            this.lblHospitalName.Size = new System.Drawing.Size(76, 13);
            this.lblHospitalName.TabIndex = 10;
            this.lblHospitalName.Text = "Hospital Name";
            // 
            // lblHospital
            // 
            this.lblHospital.AutoSize = true;
            this.lblHospital.Location = new System.Drawing.Point(488, 19);
            this.lblHospital.Name = "lblHospital";
            this.lblHospital.Size = new System.Drawing.Size(0, 13);
            this.lblHospital.TabIndex = 11;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(163, 49);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(133, 20);
            this.txtage.TabIndex = 12;
            // 
            // txtmedicines
            // 
            this.txtmedicines.Location = new System.Drawing.Point(163, 119);
            this.txtmedicines.Multiline = true;
            this.txtmedicines.Name = "txtmedicines";
            this.txtmedicines.Size = new System.Drawing.Size(144, 53);
            this.txtmedicines.TabIndex = 13;
            // 
            // txtdisease
            // 
            this.txtdisease.Location = new System.Drawing.Point(163, 195);
            this.txtdisease.Multiline = true;
            this.txtdisease.Name = "txtdisease";
            this.txtdisease.Size = new System.Drawing.Size(144, 51);
            this.txtdisease.TabIndex = 14;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(32, 52);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 15;
            this.lblAge.Text = "Age";
            // 
            // lblMedicines
            // 
            this.lblMedicines.AutoSize = true;
            this.lblMedicines.Location = new System.Drawing.Point(32, 122);
            this.lblMedicines.Name = "lblMedicines";
            this.lblMedicines.Size = new System.Drawing.Size(55, 13);
            this.lblMedicines.TabIndex = 16;
            this.lblMedicines.Text = "Medicines";
            // 
            // lblDisease
            // 
            this.lblDisease.AutoSize = true;
            this.lblDisease.Location = new System.Drawing.Point(32, 195);
            this.lblDisease.Name = "lblDisease";
            this.lblDisease.Size = new System.Drawing.Size(45, 13);
            this.lblDisease.TabIndex = 17;
            this.lblDisease.Text = "Disease";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(246, 325);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(75, 23);
            this.cmdAdd.TabIndex = 18;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // PatientHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 434);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.lblDisease);
            this.Controls.Add(this.lblMedicines);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtdisease);
            this.Controls.Add(this.txtmedicines);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.lblHospital);
            this.Controls.Add(this.lblHospitalName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gv6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linklblShowHistory);
            this.Controls.Add(this.cmdNewPatient);
            this.Controls.Add(this.cmdupdate);
            this.Controls.Add(this.cmdLogout);
            this.Controls.Add(this.lblCNIC);
            this.Name = "PatientHistory";
            this.Text = "PatientHistory";
            this.Load += new System.EventHandler(this.PatientHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCNIC;
        private System.Windows.Forms.Button cmdLogout;
        private System.Windows.Forms.Button cmdupdate;
        private System.Windows.Forms.Button cmdNewPatient;
        private System.Windows.Forms.LinkLabel linklblShowHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gv6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHospitalName;
        private System.Windows.Forms.Label lblHospital;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtmedicines;
        private System.Windows.Forms.TextBox txtdisease;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblMedicines;
        private System.Windows.Forms.Label lblDisease;
        private System.Windows.Forms.Button cmdAdd;
    }
}