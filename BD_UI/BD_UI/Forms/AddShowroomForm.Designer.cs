namespace BD_UI
{
    partial class AddShowroomForm
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
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxIDshowroom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxShowroomName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxShowroomAdress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkedListBoxCars = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxWorkers = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = global::BD_UI.Properties.Resources.Xgradient;
            this.pictureBoxClose.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(18, 19);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 45;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxIDshowroom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxShowroomName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxShowroomAdress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(35, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 190);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane salonu";
            // 
            // textBoxIDshowroom
            // 
            this.textBoxIDshowroom.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxIDshowroom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIDshowroom.Location = new System.Drawing.Point(156, 139);
            this.textBoxIDshowroom.Multiline = true;
            this.textBoxIDshowroom.Name = "textBoxIDshowroom";
            this.textBoxIDshowroom.Size = new System.Drawing.Size(302, 21);
            this.textBoxIDshowroom.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(36, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "ID salonu";
            // 
            // textBoxShowroomName
            // 
            this.textBoxShowroomName.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxShowroomName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxShowroomName.Location = new System.Drawing.Point(156, 39);
            this.textBoxShowroomName.Multiline = true;
            this.textBoxShowroomName.Name = "textBoxShowroomName";
            this.textBoxShowroomName.Size = new System.Drawing.Size(302, 21);
            this.textBoxShowroomName.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nazwa Salonu";
            // 
            // textBoxShowroomAdress
            // 
            this.textBoxShowroomAdress.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxShowroomAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxShowroomAdress.Location = new System.Drawing.Point(156, 88);
            this.textBoxShowroomAdress.Multiline = true;
            this.textBoxShowroomAdress.Name = "textBoxShowroomAdress";
            this.textBoxShowroomAdress.Size = new System.Drawing.Size(302, 21);
            this.textBoxShowroomAdress.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(36, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Adres salonu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkedListBoxCars);
            this.groupBox2.Controls.Add(this.checkedListBoxWorkers);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(35, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 244);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zasoby";
            // 
            // checkedListBoxCars
            // 
            this.checkedListBoxCars.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkedListBoxCars.FormattingEnabled = true;
            this.checkedListBoxCars.Items.AddRange(new object[] {
            "pojazd1",
            "pojazd2",
            "pojazd3"});
            this.checkedListBoxCars.Location = new System.Drawing.Point(120, 133);
            this.checkedListBoxCars.Name = "checkedListBoxCars";
            this.checkedListBoxCars.ScrollAlwaysVisible = true;
            this.checkedListBoxCars.Size = new System.Drawing.Size(186, 89);
            this.checkedListBoxCars.TabIndex = 42;
            // 
            // checkedListBoxWorkers
            // 
            this.checkedListBoxWorkers.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkedListBoxWorkers.FormattingEnabled = true;
            this.checkedListBoxWorkers.Items.AddRange(new object[] {
            "pracownik1",
            "pracownik2",
            "pracownik3"});
            this.checkedListBoxWorkers.Location = new System.Drawing.Point(120, 26);
            this.checkedListBoxWorkers.Name = "checkedListBoxWorkers";
            this.checkedListBoxWorkers.ScrollAlwaysVisible = true;
            this.checkedListBoxWorkers.Size = new System.Drawing.Size(186, 89);
            this.checkedListBoxWorkers.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(20, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Pojazdy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(20, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Pracownicy";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(162, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(251, 33);
            this.label9.TabIndex = 48;
            this.label9.Text = "Dodaj nowy salon";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Image = global::BD_UI.Properties.Resources.add_button_115_46;
            this.buttonAdd.Location = new System.Drawing.Point(432, 396);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(115, 49);
            this.buttonAdd.TabIndex = 49;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // AddShowroomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 555);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddShowroomForm";
            this.Text = "AddShowroomForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxIDshowroom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxShowroomName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxShowroomAdress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox checkedListBoxWorkers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox checkedListBoxCars;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonAdd;
    }
}