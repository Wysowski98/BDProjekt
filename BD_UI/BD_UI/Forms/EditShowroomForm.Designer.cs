namespace BD_UI
{
    partial class EditShowroomForm
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
            this.listBoxShowrooms = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxShowroomID = new System.Windows.Forms.TextBox();
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxShowrooms
            // 
            this.listBoxShowrooms.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxShowrooms.FormattingEnabled = true;
            this.listBoxShowrooms.ItemHeight = 17;
            this.listBoxShowrooms.Items.AddRange(new object[] {
            "salon1",
            "salon2",
            "salon3"});
            this.listBoxShowrooms.Location = new System.Drawing.Point(41, 112);
            this.listBoxShowrooms.Name = "listBoxShowrooms";
            this.listBoxShowrooms.ScrollAlwaysVisible = true;
            this.listBoxShowrooms.Size = new System.Drawing.Size(237, 310);
            this.listBoxShowrooms.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(53, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(225, 21);
            this.label10.TabIndex = 29;
            this.label10.Text = " który chcesz zmodyfikować";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(105, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 21);
            this.label9.TabIndex = 28;
            this.label9.Text = "Wybierz salon,";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxShowroomID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxShowroomName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxShowroomAdress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(313, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 213);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane salonu";
            // 
            // textBoxShowroomID
            // 
            this.textBoxShowroomID.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxShowroomID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxShowroomID.Location = new System.Drawing.Point(6, 168);
            this.textBoxShowroomID.Multiline = true;
            this.textBoxShowroomID.Name = "textBoxShowroomID";
            this.textBoxShowroomID.Size = new System.Drawing.Size(250, 21);
            this.textBoxShowroomID.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(95, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "ID salonu";
            // 
            // textBoxShowroomName
            // 
            this.textBoxShowroomName.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxShowroomName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxShowroomName.Location = new System.Drawing.Point(6, 56);
            this.textBoxShowroomName.Multiline = true;
            this.textBoxShowroomName.Name = "textBoxShowroomName";
            this.textBoxShowroomName.Size = new System.Drawing.Size(250, 21);
            this.textBoxShowroomName.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(83, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nazwa Salonu";
            // 
            // textBoxShowroomAdress
            // 
            this.textBoxShowroomAdress.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxShowroomAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxShowroomAdress.Location = new System.Drawing.Point(6, 112);
            this.textBoxShowroomAdress.Multiline = true;
            this.textBoxShowroomAdress.Name = "textBoxShowroomAdress";
            this.textBoxShowroomAdress.Size = new System.Drawing.Size(250, 21);
            this.textBoxShowroomAdress.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(91, 92);
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
            this.groupBox2.Location = new System.Drawing.Point(313, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 270);
            this.groupBox2.TabIndex = 48;
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
            this.checkedListBoxCars.Location = new System.Drawing.Point(25, 164);
            this.checkedListBoxCars.Name = "checkedListBoxCars";
            this.checkedListBoxCars.ScrollAlwaysVisible = true;
            this.checkedListBoxCars.Size = new System.Drawing.Size(215, 89);
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
            this.checkedListBoxWorkers.Location = new System.Drawing.Point(25, 52);
            this.checkedListBoxWorkers.Name = "checkedListBoxWorkers";
            this.checkedListBoxWorkers.ScrollAlwaysVisible = true;
            this.checkedListBoxWorkers.Size = new System.Drawing.Size(215, 89);
            this.checkedListBoxWorkers.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(108, 144);
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
            this.label7.Location = new System.Drawing.Point(96, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Pracownicy";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Image = global::BD_UI.Properties.Resources.DeleteButton_smallest_115_46;
            this.buttonDelete.Location = new System.Drawing.Point(163, 465);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(115, 49);
            this.buttonDelete.TabIndex = 50;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.BackColor = System.Drawing.Color.Transparent;
            this.buttonModify.FlatAppearance.BorderSize = 0;
            this.buttonModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModify.Image = global::BD_UI.Properties.Resources.Edit_button_115_46;
            this.buttonModify.Location = new System.Drawing.Point(29, 465);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(115, 49);
            this.buttonModify.TabIndex = 49;
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
            this.pictureBoxClose.TabIndex = 30;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // EditShowroomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 555);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBoxShowrooms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditShowroomForm";
            this.Text = "EditShowroomForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxShowrooms;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxShowroomID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxShowroomName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxShowroomAdress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox checkedListBoxCars;
        private System.Windows.Forms.CheckedListBox checkedListBoxWorkers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonDelete;
    }
}