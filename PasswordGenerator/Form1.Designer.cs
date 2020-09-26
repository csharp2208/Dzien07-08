namespace PasswordGenerator
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericPassLength = new System.Windows.Forms.NumericUpDown();
            this.numericPassCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDigits = new System.Windows.Forms.RadioButton();
            this.rbDigitsChars = new System.Windows.Forms.RadioButton();
            this.rbAllChars = new System.Windows.Forms.RadioButton();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lbPasswords = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericPassLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPassCount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Długość hasła:";
            // 
            // numericPassLength
            // 
            this.numericPassLength.Location = new System.Drawing.Point(100, 21);
            this.numericPassLength.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericPassLength.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericPassLength.Name = "numericPassLength";
            this.numericPassLength.Size = new System.Drawing.Size(120, 20);
            this.numericPassLength.TabIndex = 1;
            this.numericPassLength.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // numericPassCount
            // 
            this.numericPassCount.Location = new System.Drawing.Point(326, 21);
            this.numericPassCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericPassCount.Name = "numericPassCount";
            this.numericPassCount.Size = new System.Drawing.Size(120, 20);
            this.numericPassCount.TabIndex = 3;
            this.numericPassCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Liczba haseł:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAllChars);
            this.groupBox1.Controls.Add(this.rbDigitsChars);
            this.groupBox1.Controls.Add(this.rbDigits);
            this.groupBox1.Location = new System.Drawing.Point(16, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 228);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rodzaj hasła";
            // 
            // rbDigits
            // 
            this.rbDigits.AutoSize = true;
            this.rbDigits.Location = new System.Drawing.Point(28, 42);
            this.rbDigits.Name = "rbDigits";
            this.rbDigits.Size = new System.Drawing.Size(76, 17);
            this.rbDigits.TabIndex = 0;
            this.rbDigits.TabStop = true;
            this.rbDigits.Text = "Tylko cyfry";
            this.rbDigits.UseVisualStyleBackColor = true;
            // 
            // rbDigitsChars
            // 
            this.rbDigitsChars.AutoSize = true;
            this.rbDigitsChars.Location = new System.Drawing.Point(28, 106);
            this.rbDigitsChars.Name = "rbDigitsChars";
            this.rbDigitsChars.Size = new System.Drawing.Size(77, 17);
            this.rbDigitsChars.TabIndex = 1;
            this.rbDigitsChars.TabStop = true;
            this.rbDigitsChars.Text = "Cyfry i litery";
            this.rbDigitsChars.UseVisualStyleBackColor = true;
            // 
            // rbAllChars
            // 
            this.rbAllChars.AutoSize = true;
            this.rbAllChars.Checked = true;
            this.rbAllChars.Location = new System.Drawing.Point(28, 175);
            this.rbAllChars.Name = "rbAllChars";
            this.rbAllChars.Size = new System.Drawing.Size(137, 17);
            this.rbAllChars.TabIndex = 2;
            this.rbAllChars.TabStop = true;
            this.rbAllChars.Text = "Cyfry, litery i znaki spec.";
            this.rbAllChars.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGenerate.Location = new System.Drawing.Point(354, 143);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(151, 91);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "GENERUJ";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lbPasswords
            // 
            this.lbPasswords.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbPasswords.FormattingEnabled = true;
            this.lbPasswords.ItemHeight = 21;
            this.lbPasswords.Location = new System.Drawing.Point(16, 326);
            this.lbPasswords.Name = "lbPasswords";
            this.lbPasswords.Size = new System.Drawing.Size(489, 193);
            this.lbPasswords.TabIndex = 6;
            this.lbPasswords.DoubleClick += new System.EventHandler(this.lbPasswords_DoubleClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 542);
            this.Controls.Add(this.lbPasswords);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericPassCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericPassLength);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Generator haseł";
            ((System.ComponentModel.ISupportInitialize)(this.numericPassLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPassCount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericPassLength;
        private System.Windows.Forms.NumericUpDown numericPassCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAllChars;
        private System.Windows.Forms.RadioButton rbDigitsChars;
        private System.Windows.Forms.RadioButton rbDigits;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ListBox lbPasswords;
    }
}

