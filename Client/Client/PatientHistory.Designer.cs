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
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdNewPatient = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.linklblShowHistory = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gv6 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gv6)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCNIC
            // 
            this.lblCNIC.AutoSize = true;
            this.lblCNIC.Location = new System.Drawing.Point(337, 42);
            this.lblCNIC.Name = "lblCNIC";
            this.lblCNIC.Size = new System.Drawing.Size(0, 13);
            this.lblCNIC.TabIndex = 0;
            this.lblCNIC.Click += new System.EventHandler(this.lblCNIC_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "CNIC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // gv6
            // 
            this.gv6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv6.Location = new System.Drawing.Point(69, 134);
            this.gv6.Name = "gv6";
            this.gv6.Size = new System.Drawing.Size(614, 234);
            this.gv6.TabIndex = 7;
            this.gv6.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv6_CellContentClick);
            // 
            // PatientHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 434);
            this.Controls.Add(this.gv6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linklblShowHistory);
            this.Controls.Add(this.cmdPrint);
            this.Controls.Add(this.cmdEdit);
            this.Controls.Add(this.cmdNewPatient);
            this.Controls.Add(this.cmdSave);
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
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdNewPatient;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.Button cmdPrint;
        private System.Windows.Forms.LinkLabel linklblShowHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gv6;
    }
}