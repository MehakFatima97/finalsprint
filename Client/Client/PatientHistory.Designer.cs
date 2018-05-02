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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCNIC = new System.Windows.Forms.Label();
            this.txtCNIC = new System.Windows.Forms.TextBox();
            this.cmdLogout = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdNewPatient = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.gv6 = new System.Windows.Forms.DataGridView();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hospital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicines = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linklblShowHistory = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gv6)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(169, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(289, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblCNIC
            // 
            this.lblCNIC.AutoSize = true;
            this.lblCNIC.Location = new System.Drawing.Point(169, 87);
            this.lblCNIC.Name = "lblCNIC";
            this.lblCNIC.Size = new System.Drawing.Size(32, 13);
            this.lblCNIC.TabIndex = 0;
            this.lblCNIC.Text = "CNIC";
            // 
            // txtCNIC
            // 
            this.txtCNIC.Location = new System.Drawing.Point(289, 80);
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(100, 20);
            this.txtCNIC.TabIndex = 1;
            // 
            // cmdLogout
            // 
            this.cmdLogout.Location = new System.Drawing.Point(35, 388);
            this.cmdLogout.Name = "cmdLogout";
            this.cmdLogout.Size = new System.Drawing.Size(75, 23);
            this.cmdLogout.TabIndex = 2;
            this.cmdLogout.Text = "Logout";
            this.cmdLogout.UseVisualStyleBackColor = true;
            this.cmdLogout.Click += new System.EventHandler(this.cmdLogout_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(172, 388);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 2;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdNewPatient
            // 
            this.cmdNewPatient.Location = new System.Drawing.Point(300, 388);
            this.cmdNewPatient.Name = "cmdNewPatient";
            this.cmdNewPatient.Size = new System.Drawing.Size(75, 23);
            this.cmdNewPatient.TabIndex = 2;
            this.cmdNewPatient.Text = "New Patient";
            this.cmdNewPatient.UseVisualStyleBackColor = true;
            this.cmdNewPatient.Click += new System.EventHandler(this.cmdNewPatient_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Location = new System.Drawing.Point(429, 388);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(75, 23);
            this.cmdEdit.TabIndex = 2;
            this.cmdEdit.Text = "Edit";
            this.cmdEdit.UseVisualStyleBackColor = true;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdPrint
            // 
            this.cmdPrint.Location = new System.Drawing.Point(572, 388);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(75, 23);
            this.cmdPrint.TabIndex = 2;
            this.cmdPrint.Text = "Print";
            this.cmdPrint.UseVisualStyleBackColor = true;
            // 
            // gv6
            // 
            this.gv6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Age,
            this.CNIC,
            this.Date,
            this.Disease,
            this.Doctor,
            this.Hospital,
            this.Medicines});
            this.gv6.Location = new System.Drawing.Point(12, 125);
            this.gv6.Name = "gv6";
            this.gv6.Size = new System.Drawing.Size(742, 257);
            this.gv6.TabIndex = 3;
            this.gv6.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            // 
            // CNIC
            // 
            this.CNIC.HeaderText = "CNIC";
            this.CNIC.Name = "CNIC";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Disease
            // 
            this.Disease.HeaderText = "Disease";
            this.Disease.Name = "Disease";
            // 
            // Doctor
            // 
            this.Doctor.HeaderText = "Doctor";
            this.Doctor.Name = "Doctor";
            // 
            // Hospital
            // 
            this.Hospital.HeaderText = "Hospital";
            this.Hospital.Name = "Hospital";
            // 
            // Medicines
            // 
            this.Medicines.HeaderText = "Medicines";
            this.Medicines.Name = "Medicines";
            // 
            // linklblShowHistory
            // 
            this.linklblShowHistory.AutoSize = true;
            this.linklblShowHistory.Location = new System.Drawing.Point(560, 87);
            this.linklblShowHistory.Name = "linklblShowHistory";
            this.linklblShowHistory.Size = new System.Drawing.Size(69, 13);
            this.linklblShowHistory.TabIndex = 4;
            this.linklblShowHistory.TabStop = true;
            this.linklblShowHistory.Text = "Show History";
            this.linklblShowHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblShowHistory_LinkClicked);
            // 
            // PatientHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 434);
            this.Controls.Add(this.linklblShowHistory);
            this.Controls.Add(this.gv6);
            this.Controls.Add(this.cmdPrint);
            this.Controls.Add(this.cmdEdit);
            this.Controls.Add(this.cmdNewPatient);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdLogout);
            this.Controls.Add(this.txtCNIC);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCNIC);
            this.Controls.Add(this.lblName);
            this.Name = "PatientHistory";
            this.Text = "PatientHistory";
            ((System.ComponentModel.ISupportInitialize)(this.gv6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCNIC;
        private System.Windows.Forms.TextBox txtCNIC;
        private System.Windows.Forms.Button cmdLogout;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdNewPatient;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.Button cmdPrint;
        private System.Windows.Forms.DataGridView gv6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disease;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hospital;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicines;
        private System.Windows.Forms.LinkLabel linklblShowHistory;
    }
}