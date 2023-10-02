namespace UI.Forms
{
    partial class frmEditContact
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
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            rtxtDescription = new System.Windows.Forms.RichTextBox();
            txtPhoneNumber = new System.Windows.Forms.TextBox();
            txtCompany = new System.Windows.Forms.TextBox();
            txtLastName = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(112, 432);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(108, 23);
            button2.TabIndex = 17;
            button2.Text = "بازگشت";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(226, 432);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(142, 23);
            button1.TabIndex = 16;
            button1.Text = "ویرایش مخاطب";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new System.Drawing.Point(112, 312);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new System.Drawing.Size(256, 96);
            rtxtDescription.TabIndex = 15;
            rtxtDescription.Text = "";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new System.Drawing.Point(112, 265);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new System.Drawing.Size(256, 23);
            txtPhoneNumber.TabIndex = 11;
            // 
            // txtCompany
            // 
            txtCompany.Location = new System.Drawing.Point(112, 216);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new System.Drawing.Size(256, 23);
            txtCompany.TabIndex = 12;
            // 
            // txtLastName
            // 
            txtLastName.Location = new System.Drawing.Point(112, 169);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new System.Drawing.Size(256, 23);
            txtLastName.TabIndex = 13;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(112, 127);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(256, 23);
            txtName.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(403, 315);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(57, 15);
            label6.TabIndex = 5;
            label6.Text = "توضیحات:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(403, 272);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(71, 15);
            label5.TabIndex = 6;
            label5.Text = "شماره تماس:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(403, 223);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(40, 15);
            label4.TabIndex = 7;
            label4.Text = "شرکت:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(403, 168);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(72, 15);
            label3.TabIndex = 8;
            label3.Text = "نام خانوادگی:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(403, 130);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(24, 15);
            label2.TabIndex = 9;
            label2.Text = "نام:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Yellow;
            label1.Location = new System.Drawing.Point(134, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(212, 33);
            label1.TabIndex = 10;
            label1.Text = "ویرایش مخاطب";
            // 
            // frmEditContact
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlDark;
            ClientSize = new System.Drawing.Size(495, 476);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(rtxtDescription);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtCompany);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = System.Drawing.Color.Gray;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmEditContact";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "frmEditContact";
            Load += frmEditContact_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}