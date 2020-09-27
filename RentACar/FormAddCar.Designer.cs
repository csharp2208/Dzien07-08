namespace RentACar
{
    partial class FormAddCar
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
            this.cbBrands = new System.Windows.Forms.ComboBox();
            this.cbModels = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTypes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFuel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.numEngine = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbRegPlate = new System.Windows.Forms.MaskedTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picCar = new System.Windows.Forms.PictureBox();
            this.btnInsertPic = new System.Windows.Forms.Button();
            this.btnRemovePic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEngine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka";
            // 
            // cbBrands
            // 
            this.cbBrands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrands.FormattingEnabled = true;
            this.cbBrands.Location = new System.Drawing.Point(138, 32);
            this.cbBrands.Name = "cbBrands";
            this.cbBrands.Size = new System.Drawing.Size(155, 21);
            this.cbBrands.TabIndex = 1;
            // 
            // cbModels
            // 
            this.cbModels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModels.FormattingEnabled = true;
            this.cbModels.Location = new System.Drawing.Point(138, 82);
            this.cbModels.Name = "cbModels";
            this.cbModels.Size = new System.Drawing.Size(155, 21);
            this.cbModels.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(32, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model";
            // 
            // cbTypes
            // 
            this.cbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypes.FormattingEnabled = true;
            this.cbTypes.Location = new System.Drawing.Point(139, 132);
            this.cbTypes.Name = "cbTypes";
            this.cbTypes.Size = new System.Drawing.Size(155, 21);
            this.cbTypes.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(33, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Typ własności";
            // 
            // cbFuel
            // 
            this.cbFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuel.FormattingEnabled = true;
            this.cbFuel.Items.AddRange(new object[] {
            "PB",
            "ON",
            "LPG"});
            this.cbFuel.Location = new System.Drawing.Point(138, 353);
            this.cbFuel.Name = "cbFuel";
            this.cbFuel.Size = new System.Drawing.Size(155, 21);
            this.cbFuel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(32, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Paliwo";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(33, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rok produkcji";
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(139, 188);
            this.numYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(154, 20);
            this.numYear.TabIndex = 9;
            this.numYear.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            // 
            // numEngine
            // 
            this.numEngine.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numEngine.Location = new System.Drawing.Point(139, 246);
            this.numEngine.Maximum = new decimal(new int[] {
            6500,
            0,
            0,
            0});
            this.numEngine.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numEngine.Name = "numEngine";
            this.numEngine.Size = new System.Drawing.Size(154, 20);
            this.numEngine.TabIndex = 11;
            this.numEngine.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(33, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Poj, silnika";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(32, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nr rejestracyjny";
            // 
            // tbRegPlate
            // 
            this.tbRegPlate.Location = new System.Drawing.Point(139, 302);
            this.tbRegPlate.Mask = ">aaaaaaa";
            this.tbRegPlate.Name = "tbRegPlate";
            this.tbRegPlate.Size = new System.Drawing.Size(153, 20);
            this.tbRegPlate.TabIndex = 13;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(162, 400);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(132, 38);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "ZAPISZ";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(535, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 38);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "ANULUJ";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // picCar
            // 
            this.picCar.Location = new System.Drawing.Point(345, 32);
            this.picCar.Name = "picCar";
            this.picCar.Size = new System.Drawing.Size(300, 300);
            this.picCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCar.TabIndex = 16;
            this.picCar.TabStop = false;
            // 
            // btnInsertPic
            // 
            this.btnInsertPic.Location = new System.Drawing.Point(667, 32);
            this.btnInsertPic.Name = "btnInsertPic";
            this.btnInsertPic.Size = new System.Drawing.Size(121, 23);
            this.btnInsertPic.TabIndex = 17;
            this.btnInsertPic.Text = "Załaduj obraz";
            this.btnInsertPic.UseVisualStyleBackColor = true;
            this.btnInsertPic.Click += new System.EventHandler(this.btnInsertPic_Click);
            // 
            // btnRemovePic
            // 
            this.btnRemovePic.Location = new System.Drawing.Point(667, 309);
            this.btnRemovePic.Name = "btnRemovePic";
            this.btnRemovePic.Size = new System.Drawing.Size(121, 23);
            this.btnRemovePic.TabIndex = 18;
            this.btnRemovePic.Text = "Usuń obraz";
            this.btnRemovePic.UseVisualStyleBackColor = true;
            this.btnRemovePic.Click += new System.EventHandler(this.btnRemovePic_Click);
            // 
            // FormAddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemovePic);
            this.Controls.Add(this.btnInsertPic);
            this.Controls.Add(this.picCar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbRegPlate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numEngine);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbFuel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTypes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbModels);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBrands);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj nowy samochód";
            this.Load += new System.EventHandler(this.FormAddCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEngine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBrands;
        private System.Windows.Forms.ComboBox cbModels;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTypes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFuel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.NumericUpDown numEngine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox tbRegPlate;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox picCar;
        private System.Windows.Forms.Button btnInsertPic;
        private System.Windows.Forms.Button btnRemovePic;
    }
}