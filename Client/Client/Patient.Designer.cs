namespace Client
{
    partial class Patient
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
            this.lblPatientCNIC = new System.Windows.Forms.Label();
            this.txtPatientCNIC = new System.Windows.Forms.TextBox();
            this.cmdNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPatientCNIC
            // 
            this.lblPatientCNIC.AutoSize = true;
            this.lblPatientCNIC.Location = new System.Drawing.Point(29, 68);
            this.lblPatientCNIC.Name = "lblPatientCNIC";
            this.lblPatientCNIC.Size = new System.Drawing.Size(68, 13);
            this.lblPatientCNIC.TabIndex = 0;
            this.lblPatientCNIC.Text = "Patient CNIC";
            // 
            // txtPatientCNIC
            // 
            this.txtPatientCNIC.Location = new System.Drawing.Point(114, 65);
            this.txtPatientCNIC.Name = "txtPatientCNIC";
            this.txtPatientCNIC.Size = new System.Drawing.Size(242, 20);
            this.txtPatientCNIC.TabIndex = 1;
            this.txtPatientCNIC.TextChanged += new System.EventHandler(this.txtPatientCNIC_TextChanged);
            // 
            // cmdNext
            // 
            this.cmdNext.Location = new System.Drawing.Point(161, 156);
            this.cmdNext.Name = "cmdNext";
            this.cmdNext.Size = new System.Drawing.Size(75, 23);
            this.cmdNext.TabIndex = 2;
            this.cmdNext.Text = "Next";
            this.cmdNext.UseVisualStyleBackColor = true;
            this.cmdNext.Click += new System.EventHandler(this.cmdNext_Click);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 261);
            this.Controls.Add(this.cmdNext);
            this.Controls.Add(this.txtPatientCNIC);
            this.Controls.Add(this.lblPatientCNIC);
            this.Name = "Patient";
            this.Text = "Patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPatientCNIC;
        private System.Windows.Forms.TextBox txtPatientCNIC;
        private System.Windows.Forms.Button cmdNext;
    }
}