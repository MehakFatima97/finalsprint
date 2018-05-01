namespace Client
{
    partial class History
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
            this.cmdPrint = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCNIC = new System.Windows.Forms.Label();
            this.linkblBack = new System.Windows.Forms.LinkLabel();
            this.gv5 = new System.Windows.Forms.DataGridView();
            this.linklblDoctorTimeTable = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv5)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdPrint
            // 
            this.cmdPrint.Location = new System.Drawing.Point(511, 328);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(75, 23);
            this.cmdPrint.TabIndex = 0;
            this.cmdPrint.Text = "Print";
            this.cmdPrint.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(289, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblCNIC
            // 
            this.lblCNIC.AutoSize = true;
            this.lblCNIC.Location = new System.Drawing.Point(289, 70);
            this.lblCNIC.Name = "lblCNIC";
            this.lblCNIC.Size = new System.Drawing.Size(0, 13);
            this.lblCNIC.TabIndex = 2;
            // 
            // linkblBack
            // 
            this.linkblBack.AutoSize = true;
            this.linkblBack.Location = new System.Drawing.Point(29, 338);
            this.linkblBack.Name = "linkblBack";
            this.linkblBack.Size = new System.Drawing.Size(32, 13);
            this.linkblBack.TabIndex = 4;
            this.linkblBack.TabStop = true;
            this.linkblBack.Text = "Back";
            this.linkblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkblBack_LinkClicked);
            // 
            // gv5
            // 
            this.gv5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv5.Location = new System.Drawing.Point(109, 120);
            this.gv5.Name = "gv5";
            this.gv5.Size = new System.Drawing.Size(380, 190);
            this.gv5.TabIndex = 8;
            this.gv5.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv5_CellContentClick);
            // 
            // linklblDoctorTimeTable
            // 
            this.linklblDoctorTimeTable.AutoSize = true;
            this.linklblDoctorTimeTable.Location = new System.Drawing.Point(508, 26);
            this.linklblDoctorTimeTable.Name = "linklblDoctorTimeTable";
            this.linklblDoctorTimeTable.Size = new System.Drawing.Size(95, 13);
            this.linklblDoctorTimeTable.TabIndex = 9;
            this.linklblDoctorTimeTable.TabStop = true;
            this.linklblDoctorTimeTable.Text = "Doctor Time Table";
            this.linklblDoctorTimeTable.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblDoctorTimeTable_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "CNIC";
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 376);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linklblDoctorTimeTable);
            this.Controls.Add(this.gv5);
            this.Controls.Add(this.linkblBack);
            this.Controls.Add(this.lblCNIC);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmdPrint);
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdPrint;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCNIC;
        private System.Windows.Forms.LinkLabel linkblBack;
        private System.Windows.Forms.DataGridView gv5;
        private System.Windows.Forms.LinkLabel linklblDoctorTimeTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}