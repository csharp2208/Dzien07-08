﻿namespace DataBindExample
{
    partial class Form1
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
            this.lbPersons = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.tbLName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbJob = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPersons
            // 
            this.lbPersons.FormattingEnabled = true;
            this.lbPersons.Location = new System.Drawing.Point(13, 13);
            this.lbPersons.Name = "lbPersons";
            this.lbPersons.Size = new System.Drawing.Size(322, 407);
            this.lbPersons.TabIndex = 0;
            this.lbPersons.SelectedIndexChanged += new System.EventHandler(this.lbPersons_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imię";
            // 
            // tbFname
            // 
            this.tbFname.Location = new System.Drawing.Point(372, 30);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(246, 20);
            this.tbFname.TabIndex = 2;
            // 
            // tbLName
            // 
            this.tbLName.Location = new System.Drawing.Point(372, 82);
            this.tbLName.Name = "tbLName";
            this.tbLName.Size = new System.Drawing.Size(246, 20);
            this.tbLName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwisko";
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(372, 141);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(246, 20);
            this.tbAge.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wiek";
            // 
            // tbJob
            // 
            this.tbJob.Location = new System.Drawing.Point(372, 205);
            this.tbJob.Name = "tbJob";
            this.tbJob.Size = new System.Drawing.Size(246, 20);
            this.tbJob.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Zawód";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbJob);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPersons);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPersons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.TextBox tbLName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbJob;
        private System.Windows.Forms.Label label4;
    }
}

