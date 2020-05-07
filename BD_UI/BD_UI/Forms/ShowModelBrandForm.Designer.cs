namespace BD_UI
{
    partial class ShowModelBrandForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxModel = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxModelBrandID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxModelID = new System.Windows.Forms.TextBox();
            this.textBoxModelName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxWorker = new System.Windows.Forms.GroupBox();
            this.listBoxWorkers = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxWorkerName = new System.Windows.Forms.TextBox();
            this.textBoxWorkerID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxBrand = new System.Windows.Forms.GroupBox();
            this.listBoxBrands = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBrandID = new System.Windows.Forms.TextBox();
            this.textBoxBrandName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxWorker.SuspendLayout();
            this.groupBoxBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxModel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxModelBrandID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxModelID);
            this.groupBox1.Controls.Add(this.textBoxModelName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(394, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 437);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Model pojazdu";
            // 
            // listBoxModel
            // 
            this.listBoxModel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxModel.FormattingEnabled = true;
            this.listBoxModel.ItemHeight = 17;
            this.listBoxModel.Items.AddRange(new object[] {
            "model1",
            "model2",
            "model3"});
            this.listBoxModel.Location = new System.Drawing.Point(25, 42);
            this.listBoxModel.Name = "listBoxModel";
            this.listBoxModel.ScrollAlwaysVisible = true;
            this.listBoxModel.Size = new System.Drawing.Size(145, 174);
            this.listBoxModel.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(66, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "ID marki";
            // 
            // textBoxModelBrandID
            // 
            this.textBoxModelBrandID.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxModelBrandID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxModelBrandID.Location = new System.Drawing.Point(49, 378);
            this.textBoxModelBrandID.Multiline = true;
            this.textBoxModelBrandID.Name = "textBoxModelBrandID";
            this.textBoxModelBrandID.ReadOnly = true;
            this.textBoxModelBrandID.Size = new System.Drawing.Size(85, 21);
            this.textBoxModelBrandID.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(66, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "ID modelu";
            // 
            // textBoxModelID
            // 
            this.textBoxModelID.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxModelID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxModelID.Location = new System.Drawing.Point(49, 326);
            this.textBoxModelID.Multiline = true;
            this.textBoxModelID.Name = "textBoxModelID";
            this.textBoxModelID.ReadOnly = true;
            this.textBoxModelID.Size = new System.Drawing.Size(85, 21);
            this.textBoxModelID.TabIndex = 1;
            // 
            // textBoxModelName
            // 
            this.textBoxModelName.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxModelName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxModelName.Location = new System.Drawing.Point(16, 272);
            this.textBoxModelName.Multiline = true;
            this.textBoxModelName.Name = "textBoxModelName";
            this.textBoxModelName.ReadOnly = true;
            this.textBoxModelName.Size = new System.Drawing.Size(163, 21);
            this.textBoxModelName.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(46, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Nazwa modelu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(79, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(313, 21);
            this.label10.TabIndex = 62;
            this.label10.Text = "aby wyświetlić szczegółowe informacje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(63, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 21);
            this.label5.TabIndex = 61;
            this.label5.Text = "Wybierz rekord,";
            // 
            // groupBoxWorker
            // 
            this.groupBoxWorker.Controls.Add(this.listBoxWorkers);
            this.groupBoxWorker.Controls.Add(this.label3);
            this.groupBoxWorker.Controls.Add(this.textBoxWorkerName);
            this.groupBoxWorker.Controls.Add(this.textBoxWorkerID);
            this.groupBoxWorker.Controls.Add(this.label4);
            this.groupBoxWorker.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBoxWorker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxWorker.Location = new System.Drawing.Point(12, 283);
            this.groupBoxWorker.Name = "groupBoxWorker";
            this.groupBoxWorker.Size = new System.Drawing.Size(361, 158);
            this.groupBoxWorker.TabIndex = 58;
            this.groupBoxWorker.TabStop = false;
            this.groupBoxWorker.Text = "Stanowisko pracownika";
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
            this.listBoxWorkers.Location = new System.Drawing.Point(6, 37);
            this.listBoxWorkers.Name = "listBoxWorkers";
            this.listBoxWorkers.ScrollAlwaysVisible = true;
            this.listBoxWorkers.Size = new System.Drawing.Size(145, 106);
            this.listBoxWorkers.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(207, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nazwa stanowiska";
            // 
            // textBoxWorkerName
            // 
            this.textBoxWorkerName.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxWorkerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWorkerName.Location = new System.Drawing.Point(161, 57);
            this.textBoxWorkerName.Multiline = true;
            this.textBoxWorkerName.Name = "textBoxWorkerName";
            this.textBoxWorkerName.ReadOnly = true;
            this.textBoxWorkerName.Size = new System.Drawing.Size(186, 21);
            this.textBoxWorkerName.TabIndex = 1;
            // 
            // textBoxWorkerID
            // 
            this.textBoxWorkerID.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxWorkerID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWorkerID.Location = new System.Drawing.Point(210, 111);
            this.textBoxWorkerID.Multiline = true;
            this.textBoxWorkerID.Name = "textBoxWorkerID";
            this.textBoxWorkerID.ReadOnly = true;
            this.textBoxWorkerID.Size = new System.Drawing.Size(85, 21);
            this.textBoxWorkerID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(207, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID stanowiska";
            // 
            // groupBoxBrand
            // 
            this.groupBoxBrand.Controls.Add(this.listBoxBrands);
            this.groupBoxBrand.Controls.Add(this.label1);
            this.groupBoxBrand.Controls.Add(this.textBoxBrandID);
            this.groupBoxBrand.Controls.Add(this.textBoxBrandName);
            this.groupBoxBrand.Controls.Add(this.label2);
            this.groupBoxBrand.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBoxBrand.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxBrand.Location = new System.Drawing.Point(12, 104);
            this.groupBoxBrand.Name = "groupBoxBrand";
            this.groupBoxBrand.Size = new System.Drawing.Size(361, 158);
            this.groupBoxBrand.TabIndex = 57;
            this.groupBoxBrand.TabStop = false;
            this.groupBoxBrand.Text = "Marka pojazdu";
            // 
            // listBoxBrands
            // 
            this.listBoxBrands.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxBrands.FormattingEnabled = true;
            this.listBoxBrands.ItemHeight = 17;
            this.listBoxBrands.Items.AddRange(new object[] {
            "marka1",
            "marka2",
            "marka3"});
            this.listBoxBrands.Location = new System.Drawing.Point(6, 26);
            this.listBoxBrands.Name = "listBoxBrands";
            this.listBoxBrands.ScrollAlwaysVisible = true;
            this.listBoxBrands.Size = new System.Drawing.Size(143, 106);
            this.listBoxBrands.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(227, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID marki";
            // 
            // textBoxBrandID
            // 
            this.textBoxBrandID.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxBrandID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBrandID.Location = new System.Drawing.Point(210, 106);
            this.textBoxBrandID.Multiline = true;
            this.textBoxBrandID.Name = "textBoxBrandID";
            this.textBoxBrandID.ReadOnly = true;
            this.textBoxBrandID.Size = new System.Drawing.Size(85, 21);
            this.textBoxBrandID.TabIndex = 1;
            // 
            // textBoxBrandName
            // 
            this.textBoxBrandName.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxBrandName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBrandName.Location = new System.Drawing.Point(161, 62);
            this.textBoxBrandName.Multiline = true;
            this.textBoxBrandName.Name = "textBoxBrandName";
            this.textBoxBrandName.ReadOnly = true;
            this.textBoxBrandName.Size = new System.Drawing.Size(186, 21);
            this.textBoxBrandName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(212, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nazwa marki";
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = global::BD_UI.Properties.Resources.Xgradient;
            this.pictureBoxClose.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(18, 19);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 64;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.Transparent;
            this.buttonDone.FlatAppearance.BorderSize = 0;
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone.Image = global::BD_UI.Properties.Resources.Done_115_461;
            this.buttonDone.Location = new System.Drawing.Point(139, 476);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(115, 49);
            this.buttonDone.TabIndex = 48;
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // ShowModelBrandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 555);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBoxWorker);
            this.Controls.Add(this.groupBoxBrand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowModelBrandForm";
            this.Text = "ShowModelBrandForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxWorker.ResumeLayout(false);
            this.groupBoxWorker.PerformLayout();
            this.groupBoxBrand.ResumeLayout(false);
            this.groupBoxBrand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxModel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxModelBrandID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxModelID;
        private System.Windows.Forms.TextBox textBoxModelName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxWorker;
        private System.Windows.Forms.ListBox listBoxWorkers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxWorkerName;
        private System.Windows.Forms.TextBox textBoxWorkerID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxBrand;
        private System.Windows.Forms.ListBox listBoxBrands;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBrandID;
        private System.Windows.Forms.TextBox textBoxBrandName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Button buttonDone;
    }
}