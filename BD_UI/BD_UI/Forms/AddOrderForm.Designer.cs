namespace BD_UI
{
    partial class AddOrderForm
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIDcustomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxCar = new System.Windows.Forms.GroupBox();
            this.checkedListServices = new System.Windows.Forms.CheckedListBox();
            this.comboBoxShowroom = new System.Windows.Forms.ComboBox();
            this.comboBoxCar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDate2 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePickerDate1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIDorder = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBoxCustomer.SuspendLayout();
            this.groupBoxCar.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Location = new System.Drawing.Point(140, 26);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(186, 21);
            this.textBoxName.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Imię ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nazwisko";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLastName.Location = new System.Drawing.Point(140, 53);
            this.textBoxLastName.Multiline = true;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(186, 21);
            this.textBoxLastName.TabIndex = 34;
            // 
            // groupBoxCustomer
            // 
            this.groupBoxCustomer.Controls.Add(this.label14);
            this.groupBoxCustomer.Controls.Add(this.label13);
            this.groupBoxCustomer.Controls.Add(this.comboBoxCustomer);
            this.groupBoxCustomer.Controls.Add(this.textBoxPhoneNumber);
            this.groupBoxCustomer.Controls.Add(this.label4);
            this.groupBoxCustomer.Controls.Add(this.textBoxIDcustomer);
            this.groupBoxCustomer.Controls.Add(this.label3);
            this.groupBoxCustomer.Controls.Add(this.textBoxName);
            this.groupBoxCustomer.Controls.Add(this.label1);
            this.groupBoxCustomer.Controls.Add(this.textBoxLastName);
            this.groupBoxCustomer.Controls.Add(this.label2);
            this.groupBoxCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxCustomer.Location = new System.Drawing.Point(28, 70);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Size = new System.Drawing.Size(343, 194);
            this.groupBoxCustomer.TabIndex = 36;
            this.groupBoxCustomer.TabStop = false;
            this.groupBoxCustomer.Text = "Dane klienta";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(140, 107);
            this.textBoxPhoneNumber.Multiline = true;
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(186, 21);
            this.textBoxPhoneNumber.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Numer telefonu";
            // 
            // textBoxIDcustomer
            // 
            this.textBoxIDcustomer.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxIDcustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIDcustomer.Location = new System.Drawing.Point(140, 80);
            this.textBoxIDcustomer.Multiline = true;
            this.textBoxIDcustomer.Name = "textBoxIDcustomer";
            this.textBoxIDcustomer.Size = new System.Drawing.Size(186, 21);
            this.textBoxIDcustomer.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Numer dowodu";
            // 
            // groupBoxCar
            // 
            this.groupBoxCar.Controls.Add(this.checkedListServices);
            this.groupBoxCar.Controls.Add(this.comboBoxShowroom);
            this.groupBoxCar.Controls.Add(this.comboBoxCar);
            this.groupBoxCar.Controls.Add(this.label6);
            this.groupBoxCar.Controls.Add(this.label7);
            this.groupBoxCar.Controls.Add(this.label8);
            this.groupBoxCar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxCar.Location = new System.Drawing.Point(28, 270);
            this.groupBoxCar.Name = "groupBoxCar";
            this.groupBoxCar.Size = new System.Drawing.Size(343, 273);
            this.groupBoxCar.TabIndex = 40;
            this.groupBoxCar.TabStop = false;
            this.groupBoxCar.Text = "Dane pojazdu";
            // 
            // checkedListServices
            // 
            this.checkedListServices.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkedListServices.FormattingEnabled = true;
            this.checkedListServices.Items.AddRange(new object[] {
            "usługa1",
            "usługa2",
            "usługa3"});
            this.checkedListServices.Location = new System.Drawing.Point(140, 121);
            this.checkedListServices.Name = "checkedListServices";
            this.checkedListServices.ScrollAlwaysVisible = true;
            this.checkedListServices.Size = new System.Drawing.Size(186, 140);
            this.checkedListServices.TabIndex = 41;
            // 
            // comboBoxShowroom
            // 
            this.comboBoxShowroom.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxShowroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxShowroom.FormattingEnabled = true;
            this.comboBoxShowroom.ItemHeight = 21;
            this.comboBoxShowroom.Location = new System.Drawing.Point(129, 71);
            this.comboBoxShowroom.Name = "comboBoxShowroom";
            this.comboBoxShowroom.Size = new System.Drawing.Size(186, 29);
            this.comboBoxShowroom.TabIndex = 42;
            // 
            // comboBoxCar
            // 
            this.comboBoxCar.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCar.FormattingEnabled = true;
            this.comboBoxCar.Location = new System.Drawing.Point(129, 26);
            this.comboBoxCar.Name = "comboBoxCar";
            this.comboBoxCar.Size = new System.Drawing.Size(186, 29);
            this.comboBoxCar.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(19, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Usługi dodatkowe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(19, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Pojazd";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(19, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Salon";
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.dateTimePickerDate2);
            this.groupBoxDetails.Controls.Add(this.label11);
            this.groupBoxDetails.Controls.Add(this.dateTimePickerDate1);
            this.groupBoxDetails.Controls.Add(this.label10);
            this.groupBoxDetails.Controls.Add(this.label9);
            this.groupBoxDetails.Controls.Add(this.textBoxPrice);
            this.groupBoxDetails.Controls.Add(this.label5);
            this.groupBoxDetails.Controls.Add(this.textBoxIDorder);
            this.groupBoxDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxDetails.Location = new System.Drawing.Point(388, 69);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(200, 296);
            this.groupBoxDetails.TabIndex = 41;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Szczegóły zamówienia";
            // 
            // dateTimePickerDate2
            // 
            this.dateTimePickerDate2.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerDate2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate2.Location = new System.Drawing.Point(8, 247);
            this.dateTimePickerDate2.Name = "dateTimePickerDate2";
            this.dateTimePickerDate2.Size = new System.Drawing.Size(186, 27);
            this.dateTimePickerDate2.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(53, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 17);
            this.label11.TabIndex = 44;
            this.label11.Text = "Data realizacji";
            // 
            // dateTimePickerDate1
            // 
            this.dateTimePickerDate1.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerDate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate1.Location = new System.Drawing.Point(6, 173);
            this.dateTimePickerDate1.Name = "dateTimePickerDate1";
            this.dateTimePickerDate1.Size = new System.Drawing.Size(186, 27);
            this.dateTimePickerDate1.TabIndex = 43;
            this.dateTimePickerDate1.Value = new System.DateTime(2020, 4, 13, 16, 36, 17, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(53, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 17);
            this.label10.TabIndex = 42;
            this.label10.Text = "Data złożenia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(43, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 17);
            this.label9.TabIndex = 41;
            this.label9.Text = "Kwota do zapłaty";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPrice.Location = new System.Drawing.Point(8, 111);
            this.textBoxPrice.Multiline = true;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(186, 21);
            this.textBoxPrice.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(43, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Numer zamówienia";
            // 
            // textBoxIDorder
            // 
            this.textBoxIDorder.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxIDorder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIDorder.Location = new System.Drawing.Point(8, 58);
            this.textBoxIDorder.Multiline = true;
            this.textBoxIDorder.Name = "textBoxIDorder";
            this.textBoxIDorder.ReadOnly = true;
            this.textBoxIDorder.Size = new System.Drawing.Size(186, 21);
            this.textBoxIDorder.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(71, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(347, 33);
            this.label12.TabIndex = 48;
            this.label12.Text = "Dodaj nowe zamówienie";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Image = global::BD_UI.Properties.Resources.SaveChanges_115_46;
            this.buttonSave.Location = new System.Drawing.Point(434, 434);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(115, 49);
            this.buttonSave.TabIndex = 47;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = global::BD_UI.Properties.Resources.Xgradient;
            this.pictureBoxClose.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(18, 19);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 29;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(140, 152);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(186, 29);
            this.comboBoxCustomer.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(6, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 17);
            this.label13.TabIndex = 44;
            this.label13.Text = "Wybierz klienta z bazy";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(54, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 17);
            this.label14.TabIndex = 45;
            this.label14.Text = "lub";
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 555);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.groupBoxCar);
            this.Controls.Add(this.groupBoxCustomer);
            this.Controls.Add(this.pictureBoxClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddOrderForm";
            this.Text = "Form1";
            this.groupBoxCustomer.ResumeLayout(false);
            this.groupBoxCustomer.PerformLayout();
            this.groupBoxCar.ResumeLayout(false);
            this.groupBoxCar.PerformLayout();
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIDcustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxCar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox checkedListServices;
        private System.Windows.Forms.ComboBox comboBoxShowroom;
        private System.Windows.Forms.ComboBox comboBoxCar;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxIDorder;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
    }
}