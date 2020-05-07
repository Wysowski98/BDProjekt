namespace BD_UI
{
    partial class ShowShowroomForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxCars = new System.Windows.Forms.ListBox();
            this.listBoxWorkers = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxShowrooms = new System.Windows.Forms.ListBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxCars);
            this.groupBox2.Controls.Add(this.listBoxWorkers);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(320, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 270);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zasoby";
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
            this.listBoxCars.Location = new System.Drawing.Point(25, 164);
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.ScrollAlwaysVisible = true;
            this.listBoxCars.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxCars.Size = new System.Drawing.Size(215, 89);
            this.listBoxCars.TabIndex = 45;
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
            this.listBoxWorkers.Location = new System.Drawing.Point(25, 52);
            this.listBoxWorkers.Name = "listBoxWorkers";
            this.listBoxWorkers.ScrollAlwaysVisible = true;
            this.listBoxWorkers.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxWorkers.Size = new System.Drawing.Size(215, 89);
            this.listBoxWorkers.TabIndex = 44;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxAdress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(320, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 213);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane salonu";
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxID.Location = new System.Drawing.Point(6, 168);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(250, 21);
            this.textBoxID.TabIndex = 37;
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
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Location = new System.Drawing.Point(6, 56);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(250, 21);
            this.textBoxName.TabIndex = 32;
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
            // textBoxAdress
            // 
            this.textBoxAdress.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAdress.Location = new System.Drawing.Point(6, 112);
            this.textBoxAdress.Multiline = true;
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.ReadOnly = true;
            this.textBoxAdress.Size = new System.Drawing.Size(250, 21);
            this.textBoxAdress.TabIndex = 34;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(68, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 21);
            this.label10.TabIndex = 53;
            this.label10.Text = "aby wyświetlić informacje";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(112, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 21);
            this.label9.TabIndex = 52;
            this.label9.Text = "Wybierz salon,";
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
            this.listBoxShowrooms.Location = new System.Drawing.Point(48, 118);
            this.listBoxShowrooms.Name = "listBoxShowrooms";
            this.listBoxShowrooms.ScrollAlwaysVisible = true;
            this.listBoxShowrooms.Size = new System.Drawing.Size(237, 310);
            this.listBoxShowrooms.TabIndex = 51;
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.Transparent;
            this.buttonDone.FlatAppearance.BorderSize = 0;
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone.Image = global::BD_UI.Properties.Resources.Done_115_461;
            this.buttonDone.Location = new System.Drawing.Point(96, 471);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(115, 49);
            this.buttonDone.TabIndex = 57;
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = global::BD_UI.Properties.Resources.Xgradient;
            this.pictureBoxClose.Location = new System.Drawing.Point(19, 18);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(18, 19);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 54;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // ShowShowroomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 555);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBoxShowrooms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowShowroomForm";
            this.Text = "ShowShowroomForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBoxShowrooms;
        private System.Windows.Forms.ListBox listBoxCars;
        private System.Windows.Forms.ListBox listBoxWorkers;
    }
}