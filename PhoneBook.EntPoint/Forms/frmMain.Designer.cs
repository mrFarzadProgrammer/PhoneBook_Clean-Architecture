﻿namespace UI.Forms
{
    partial class frmMain
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            txtSearchKey = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            deleteContact = new System.Windows.Forms.Button();
            btnDetail = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            dataGridView1.Location = new System.Drawing.Point(0, 141);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(541, 389);
            dataGridView1.TabIndex = 0;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // txtSearchKey
            // 
            txtSearchKey.Location = new System.Drawing.Point(14, 99);
            txtSearchKey.Name = "txtSearchKey";
            txtSearchKey.Size = new System.Drawing.Size(242, 25);
            txtSearchKey.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(287, 99);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(242, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "جستجو";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // deleteContact
            // 
            deleteContact.Location = new System.Drawing.Point(285, 70);
            deleteContact.Name = "deleteContact";
            deleteContact.Size = new System.Drawing.Size(244, 23);
            deleteContact.TabIndex = 4;
            deleteContact.Text = "حذف";
            deleteContact.UseVisualStyleBackColor = true;
            deleteContact.Click += deleteContact_Click;
            // 
            // btnDetail
            // 
            btnDetail.Location = new System.Drawing.Point(12, 70);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new System.Drawing.Size(244, 23);
            btnDetail.TabIndex = 5;
            btnDetail.Text = "نمایش جزئیات";
            btnDetail.UseVisualStyleBackColor = true;
            btnDetail.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(12, 32);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(244, 23);
            button1.TabIndex = 6;
            button1.Text = "ثبت مخاطب";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(287, 32);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(242, 23);
            button2.TabIndex = 7;
            button2.Text = "ویرایش مخاطب";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(541, 530);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnDetail);
            Controls.Add(deleteContact);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchKey);
            Controls.Add(dataGridView1);
            Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            Name = "frmMain";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmMain";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearchKey;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button deleteContact;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}