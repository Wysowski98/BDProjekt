namespace BD_UI
{
    partial class EditWorkerForm
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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxWorkers = new System.Windows.Forms.ListBox();
            this.groupBoxWorker = new System.Windows.Forms.GroupBox();
            this.comboBoxWorkerPosition = new System.Windows.Forms.ComboBox();
            this.comboBoxShowroom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxWorkerAccount = new System.Windows.Forms.GroupBox();
            this.textBoxPassword2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPassword1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.groupBoxWorker.SuspendLayout();
            this.groupBoxWorkerAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(71, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 21);
            this.label10.TabIndex = 54;
            this.label10.Text = "aby dokonać modyfikacji";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(64, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 21);
            this.label9.TabIndex = 53;
            this.label9.Text = "Wybierz pracownika z listy,";
            // 
            // listBoxWorkers
            // 
            this.listBoxWorkers.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxWorkers.FormattingEnabled = true;
            this.listBoxWorkers.ItemHeight = 17;
            this.listBoxWorkers.Items.AddRange(new object[] {
            "pracownik1",
            "pracownik2",
            "pracownik3"});
            this.listBoxWorkers.Location = new System.Drawing.Point(34, 104);
            this.listBoxWorkers.Name = "listBoxWorkers";
            this.listBoxWorkers.ScrollAlwaysVisible = true;
            this.listBoxWorkers.Size = new System.Drawing.Size(227, 140);
            this.listBoxWorkers.TabIndex = 55;
            // 
            // groupBoxWorker
            // 
            this.groupBoxWorker.Controls.Add(this.comboBoxWorkerPosition);
            this.groupBoxWorker.Controls.Add(this.comboBoxShowroom);
            this.groupBoxWorker.Controls.Add(this.label5);
            this.groupBoxWorker.Controls.Add(this.label6);
            this.groupBoxWorker.Controls.Add(this.textBoxPhoneNumber);
            this.groupBoxWorker.Controls.Add(this.label4);
            this.groupBoxWorker.Controls.Add(this.textBoxID);
            this.groupBoxWorker.Controls.Add(this.label3);
            this.groupBoxWorker.Controls.Add(this.textBoxName);
            this.groupBoxWorker.Controls.Add(this.label1);
            this.groupBoxWorker.Controls.Add(this.textBoxLastName);
            this.groupBoxWorker.Controls.Add(this.label2);
            this.groupBoxWorker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxWorker.Location = new System.Drawing.Point(300, 49);
            this.groupBoxWorker.Name = "groupBoxWorker";
            this.groupBoxWorker.Size = new System.Drawing.Size(277, 390);
            this.groupBoxWorker.TabIndex = 56;
            this.groupBoxWorker.TabStop = false;
            this.groupBoxWorker.Text = "Dane pracownika";
            // 
            // comboBoxWorkerPosition
            // 
            this.comboBoxWorkerPosition.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxWorkerPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxWorkerPosition.FormattingEnabled = true;
            this.comboBoxWorkerPosition.Location = new System.Drawing.Point(26, 337);
            this.comboBoxWorkerPosition.Name = "comboBoxWorkerPosition";
            this.comboBoxWorkerPosition.Size = new System.Drawing.Size(223, 29);
            this.comboBoxWorkerPosition.TabIndex = 44;
            // 
            // comboBoxShowroom
            // 
            this.comboBoxShowroom.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxShowroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxShowroom.FormattingEnabled = true;
            this.comboBoxShowroom.Location = new System.Drawing.Point(26, 270);
            this.comboBoxShowroom.Name = "comboBoxShowroom";
            this.comboBoxShowroom.Size = new System.Drawing.Size(223, 29);
            this.comboBoxShowroom.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(89, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Stanowisko";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(89, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Adres salonu";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(26, 211);
            this.textBoxPhoneNumber.Multiline = true;
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(223, 21);
            this.textBoxPhoneNumber.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(89, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Numer telefonu";
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxID.Location = new System.Drawing.Point(26, 157);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(223, 21);
            this.textBoxID.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(89, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Numer dowodu";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Location = new System.Drawing.Point(26, 54);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(223, 21);
            this.textBoxName.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(111, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Imię ";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLastName.Location = new System.Drawing.Point(26, 106);
            this.textBoxLastName.Multiline = true;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(223, 21);
            this.textBoxLastName.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(102, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nazwisko";
            // 
            // groupBoxWorkerAccount
            // 
            this.groupBoxWorkerAccount.Controls.Add(this.textBoxPassword2);
            this.groupBoxWorkerAccount.Controls.Add(this.label8);
            this.groupBoxWorkerAccount.Controls.Add(this.textBoxUsername);
            this.groupBoxWorkerAccount.Controls.Add(this.label7);
            this.groupBoxWorkerAccount.Controls.Add(this.textBoxPassword1);
            this.groupBoxWorkerAccount.Controls.Add(this.label11);
            this.groupBoxWorkerAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxWorkerAccount.Location = new System.Drawing.Point(21, 286);
            this.groupBoxWorkerAccount.Name = "groupBoxWorkerAccount";
            this.groupBoxWorkerAccount.Size = new System.Drawing.Size(255, 233);
            this.groupBoxWorkerAccount.TabIndex = 57;
            this.groupBoxWorkerAccount.TabStop = false;
            this.groupBoxWorkerAccount.Text = "Edycja konta pracownika";
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxPassword2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword2.Location = new System.Drawing.Point(27, 180);
            this.textBoxPassword2.Multiline = true;
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.PasswordChar = '*';
            this.textBoxPassword2.Size = new System.Drawing.Size(178, 21);
            this.textBoxPassword2.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(77, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Powtórz hasło";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Location = new System.Drawing.Point(27, 62);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(178, 21);
            this.textBoxUsername.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(66, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Nazwa użytkownika";
            // 
            // textBoxPassword1
            // 
            this.textBoxPassword1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxPassword1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword1.Location = new System.Drawing.Point(27, 121);
            this.textBoxPassword1.Multiline = true;
            this.textBoxPassword1.Name = "textBoxPassword1";
            this.textBoxPassword1.PasswordChar = '*';
            this.textBoxPassword1.Size = new System.Drawing.Size(178, 21);
            this.textBoxPassword1.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(77, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 35;
            this.label11.Text = "Nowe hasło";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Image = global::BD_UI.Properties.Resources.DeleteButton_smallest_115_46;
            this.buttonDelete.Location = new System.Drawing.Point(447, 470);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(115, 49);
            this.buttonDelete.TabIndex = 59;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.BackColor = System.Drawing.Color.Transparent;
            this.buttonModify.FlatAppearance.BorderSize = 0;
            this.buttonModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModify.Image = global::BD_UI.Properties.Resources.Edit_button_115_46;
            this.buttonModify.Location = new System.Drawing.Point(326, 470);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(115, 49);
            this.buttonModify.TabIndex = 58;
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
            this.pictureBoxClose.TabIndex = 52;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // EditWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 555);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.groupBoxWorkerAccount);
            this.Controls.Add(this.groupBoxWorker);
            this.Controls.Add(this.listBoxWorkers);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBoxClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditWorkerForm";
            this.Text = "EditWorkerForm";
            this.groupBoxWorker.ResumeLayout(false);
            this.groupBoxWorker.PerformLayout();
            this.groupBoxWorkerAccount.ResumeLayout(false);
            this.groupBoxWorkerAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBoxWorkers;
        private System.Windows.Forms.GroupBox groupBoxWorker;
        private System.Windows.Forms.ComboBox comboBoxWorkerPosition;
        private System.Windows.Forms.ComboBox comboBoxShowroom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxWorkerAccount;
        private System.Windows.Forms.TextBox textBoxPassword2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPassword1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonModify;
    }
}