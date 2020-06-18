namespace BD_UI
{
    partial class SalesRankForm
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
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxNumberOfCarsOther = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxOtherShowroom = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxBestShowroom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumberOfCarsBest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(106, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(411, 33);
            this.label9.TabIndex = 34;
            this.label9.Text = "Ranking sprzedaży w salonach";
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = global::BD_UI.Properties.Resources.Xgradient;
            this.pictureBoxClose.Location = new System.Drawing.Point(12, 9);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(18, 19);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 33;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.Transparent;
            this.buttonDone.FlatAppearance.BorderSize = 0;
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone.Image = global::BD_UI.Properties.Resources.Done_115_461;
            this.buttonDone.Location = new System.Drawing.Point(375, 492);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(115, 49);
            this.buttonDone.TabIndex = 62;
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxNumberOfCarsOther);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxOtherShowroom);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(48, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 229);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pozostałe salony";
            // 
            // textBoxNumberOfCarsOther
            // 
            this.textBoxNumberOfCarsOther.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxNumberOfCarsOther.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumberOfCarsOther.Location = new System.Drawing.Point(256, 162);
            this.textBoxNumberOfCarsOther.Multiline = true;
            this.textBoxNumberOfCarsOther.Name = "textBoxNumberOfCarsOther";
            this.textBoxNumberOfCarsOther.ReadOnly = true;
            this.textBoxNumberOfCarsOther.Size = new System.Drawing.Size(67, 21);
            this.textBoxNumberOfCarsOther.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(37, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 17);
            this.label5.TabIndex = 60;
            this.label5.Text = "Liczba sprzedanych pojazdów";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(37, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 58;
            this.label4.Text = "Adres salonu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(52, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Wybierz adres salonu, aby wyświetlić informację o sprzedaży.";
            // 
            // comboBoxOtherShowroom
            // 
            this.comboBoxOtherShowroom.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxOtherShowroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxOtherShowroom.FormattingEnabled = true;
            this.comboBoxOtherShowroom.ItemHeight = 21;
            this.comboBoxOtherShowroom.Location = new System.Drawing.Point(165, 96);
            this.comboBoxOtherShowroom.Name = "comboBoxOtherShowroom";
            this.comboBoxOtherShowroom.Size = new System.Drawing.Size(255, 29);
            this.comboBoxOtherShowroom.TabIndex = 44;
            this.comboBoxOtherShowroom.SelectedIndexChanged += new System.EventHandler(this.comboBoxOtherShowroom_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxBestShowroom);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxNumberOfCarsBest);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(48, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 140);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salon z najlepszą sprzedażą";
            // 
            // textBoxBestShowroom
            // 
            this.textBoxBestShowroom.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxBestShowroom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBestShowroom.Location = new System.Drawing.Point(174, 42);
            this.textBoxBestShowroom.Multiline = true;
            this.textBoxBestShowroom.Name = "textBoxBestShowroom";
            this.textBoxBestShowroom.ReadOnly = true;
            this.textBoxBestShowroom.Size = new System.Drawing.Size(272, 21);
            this.textBoxBestShowroom.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nazwa i adres salonu";
            // 
            // textBoxNumberOfCarsBest
            // 
            this.textBoxNumberOfCarsBest.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxNumberOfCarsBest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumberOfCarsBest.Location = new System.Drawing.Point(276, 83);
            this.textBoxNumberOfCarsBest.Multiline = true;
            this.textBoxNumberOfCarsBest.Name = "textBoxNumberOfCarsBest";
            this.textBoxNumberOfCarsBest.ReadOnly = true;
            this.textBoxNumberOfCarsBest.Size = new System.Drawing.Size(67, 21);
            this.textBoxNumberOfCarsBest.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(37, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Liczba sprzedanych pojazdów";
            // 
            // SalesRankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 555);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBoxClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesRankForm";
            this.Text = "SalesRankForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxBestShowroom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumberOfCarsBest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxOtherShowroom;
        private System.Windows.Forms.TextBox textBoxNumberOfCarsOther;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}