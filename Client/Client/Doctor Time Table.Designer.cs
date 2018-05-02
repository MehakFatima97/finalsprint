namespace Client
{
    partial class Doctor_Time_Table
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
            this.gv3 = new System.Windows.Forms.DataGridView();
            this.linklblBack = new System.Windows.Forms.LinkLabel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.cmdShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(159, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(230, 20);
            this.txtName.TabIndex = 0;
            // 
            // gv3
            // 
            this.gv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv3.Location = new System.Drawing.Point(104, 139);
            this.gv3.Name = "gv3";
            this.gv3.Size = new System.Drawing.Size(366, 190);
            this.gv3.TabIndex = 1;
            this.gv3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv3_CellContentClick);
            // 
            // linklblBack
            // 
            this.linklblBack.AutoSize = true;
            this.linklblBack.Location = new System.Drawing.Point(28, 371);
            this.linklblBack.Name = "linklblBack";
            this.linklblBack.Size = new System.Drawing.Size(32, 13);
            this.linklblBack.TabIndex = 2;
            this.linklblBack.TabStop = true;
            this.linklblBack.Text = "Back";
            this.linklblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblBack_LinkClicked);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(38, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Doctor Name";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(38, 73);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 4;
            this.lblDepartment.Text = "Department";
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Items.AddRange(new object[] {
            "cardiology",
            "dentist",
            "pyscology"});
            this.comboBoxDepartment.Location = new System.Drawing.Point(159, 65);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(230, 21);
            this.comboBoxDepartment.TabIndex = 5;
            // 
            // cmdShow
            // 
            this.cmdShow.Location = new System.Drawing.Point(395, 94);
            this.cmdShow.Name = "cmdShow";
            this.cmdShow.Size = new System.Drawing.Size(75, 23);
            this.cmdShow.TabIndex = 6;
            this.cmdShow.Text = "Show";
            this.cmdShow.UseVisualStyleBackColor = true;
            this.cmdShow.Click += new System.EventHandler(this.cmdShow_Click);
            // 
            // Doctor_Time_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 393);
            this.Controls.Add(this.cmdShow);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.linklblBack);
            this.Controls.Add(this.gv3);
            this.Controls.Add(this.txtName);
            this.Name = "Doctor_Time_Table";
            this.Text = "Doctor_Time_Table";
            this.Load += new System.EventHandler(this.Doctor_Time_Table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView gv3;
        private System.Windows.Forms.LinkLabel linklblBack;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Button cmdShow;
    }
}