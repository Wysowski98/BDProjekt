namespace BD_UI
{
    partial class EditCarForm
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
            this.listBoxCars = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIDcar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.comboBoxAdress = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEngine = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBodyCar = new System.Windows.Forms.TextBox();
            this.buttonModify = new System.Windows.Forms.Button();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxCars
            // 
            this.listBoxCars.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxCars.FormattingEnabled = true;
            this.listBoxCars.ItemHeight = 17;
            this.listBoxCars.Items.AddRange(new object[] {
            "pojazd1",
            "pojazd2",
            "pojazd3"});
            this.listBoxCars.Location = new System.Drawing.Point(37, 114);
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.ScrollAlwaysVisible = true;
            this.listBoxCars.Size = new System.Drawing.Size(237, 310);
            this.listBoxCars.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(84, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 21);
            this.label9.TabIndex = 26;
            this.label9.Text = "Wybierz pojazd,";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(49, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(225, 21);
            this.label10.TabIndex = 27;
            this.label10.Text = " który chcesz zmodyfikować";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxIDcar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxPrice);
            this.groupBox1.Controls.Add(this.comboBoxAdress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxBrand);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxBodyCar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxModel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxYear);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxEngine);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(324, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 497);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane pojazdu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(47, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numer ID samochodu";
            // 
            // textBoxIDcar
            // 
            this.textBoxIDcar.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxIDcar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIDcar.Location = new System.Drawing.Point(22, 70);
            this.textBoxIDcar.Multiline = true;
            this.textBoxIDcar.Name = "textBoxIDcar";
            this.textBoxIDcar.Size = new System.Drawing.Size(186, 21);
            this.textBoxIDcar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(95, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cena";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPrice.Location = new System.Drawing.Point(22, 124);
            this.textBoxPrice.Multiline = true;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(186, 21);
            this.textBoxPrice.TabIndex = 9;
            // 
            // comboBoxAdress
            // 
            this.comboBoxAdress.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxAdress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAdress.FormattingEnabled = true;
            this.comboBoxAdress.Location = new System.Drawing.Point(22, 452);
            this.comboBoxAdress.Name = "comboBoxAdress";
            this.comboBoxAdress.Size = new System.Drawing.Size(186, 29);
            this.comboBoxAdress.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(65, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Rok produkcji";
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(22, 391);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(186, 29);
            this.comboBoxBrand.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(61, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Pojemność silnika";
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(21, 333);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(186, 29);
            this.comboBoxModel.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(88, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Model";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(75, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Adres salonu";
            // 
            // textBoxYear
            // 
            this.textBoxYear.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxYear.Location = new System.Drawing.Point(22, 177);
            this.textBoxYear.Multiline = true;
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(186, 21);
            this.textBoxYear.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(89, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Marka";
            // 
            // textBoxEngine
            // 
            this.textBoxEngine.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxEngine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEngine.Location = new System.Drawing.Point(22, 230);
            this.textBoxEngine.Multiline = true;
            this.textBoxEngine.Name = "textBoxEngine";
            this.textBoxEngine.Size = new System.Drawing.Size(186, 21);
            this.textBoxEngine.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(61, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Rodzaj nadwozia";
            // 
            // textBoxBodyCar
            // 
            this.textBoxBodyCar.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxBodyCar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBodyCar.Location = new System.Drawing.Point(18, 284);
            this.textBoxBodyCar.Multiline = true;
            this.textBoxBodyCar.Name = "textBoxBodyCar";
            this.textBoxBodyCar.Size = new System.Drawing.Size(186, 21);
            this.textBoxBodyCar.TabIndex = 18;
            // 
            // buttonModify
            // 
            this.buttonModify.BackColor = System.Drawing.Color.Transparent;
            this.buttonModify.FlatAppearance.BorderSize = 0;
            this.buttonModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModify.Image = global::BD_UI.Properties.Resources.Edit_button_115_46;
            this.buttonModify.Location = new System.Drawing.Point(37, 470);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(115, 49);
            this.buttonModify.TabIndex = 25;
            this.buttonModify.UseVisualStyleBackColor = false;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = global::BD_UI.Properties.Resources.Xgradient;
            this.pictureBoxClose.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(18, 19);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 1;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Image = global::BD_UI.Properties.Resources.DeleteButton_smallest_115_46;
            this.buttonDelete.Location = new System.Drawing.Point(174, 470);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(115, 49);
            this.buttonDelete.TabIndex = 51;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // EditCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 555);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.listBoxCars);
            this.Controls.Add(this.pictureBoxClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditCarForm";
            this.Text = "EditCarForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.ListBox listBoxCars;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIDcar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.ComboBox comboBoxAdress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxEngine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBodyCar;
        private System.Windows.Forms.Button buttonDelete;
    }
}