namespace BD_UI
{
    partial class SalesHistoryForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxCurrentOrders = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxCompletedOrders = new System.Windows.Forms.ListBox();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(171, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(244, 33);
            this.label9.TabIndex = 32;
            this.label9.Text = "Historia sprzedaży";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxCurrentOrders);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(41, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 166);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zamówienia w trakcie realizacji";
            // 
            // listBoxCurrentOrders
            // 
            this.listBoxCurrentOrders.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxCurrentOrders.FormattingEnabled = true;
            this.listBoxCurrentOrders.ItemHeight = 17;
            this.listBoxCurrentOrders.Items.AddRange(new object[] {
            "zamowienie1",
            "zamowienie2",
            "zamowienie3"});
            this.listBoxCurrentOrders.Location = new System.Drawing.Point(15, 26);
            this.listBoxCurrentOrders.Name = "listBoxCurrentOrders";
            this.listBoxCurrentOrders.ScrollAlwaysVisible = true;
            this.listBoxCurrentOrders.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxCurrentOrders.Size = new System.Drawing.Size(455, 123);
            this.listBoxCurrentOrders.TabIndex = 44;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxCompletedOrders);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(41, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 229);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zamówienia zrealizowane";
            // 
            // listBoxCompletedOrders
            // 
            this.listBoxCompletedOrders.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxCompletedOrders.FormattingEnabled = true;
            this.listBoxCompletedOrders.ItemHeight = 17;
            this.listBoxCompletedOrders.Items.AddRange(new object[] {
            "zamowienie1",
            "zamowienie2",
            "zamowienie3"});
            this.listBoxCompletedOrders.Location = new System.Drawing.Point(15, 26);
            this.listBoxCompletedOrders.Name = "listBoxCompletedOrders";
            this.listBoxCompletedOrders.ScrollAlwaysVisible = true;
            this.listBoxCompletedOrders.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxCompletedOrders.Size = new System.Drawing.Size(455, 191);
            this.listBoxCompletedOrders.TabIndex = 44;
            // 
            // buttonReport
            // 
            this.buttonReport.BackColor = System.Drawing.Color.Transparent;
            this.buttonReport.FlatAppearance.BorderSize = 0;
            this.buttonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReport.Image = global::BD_UI.Properties.Resources.generate_200_46;
            this.buttonReport.Location = new System.Drawing.Point(83, 486);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(205, 49);
            this.buttonReport.TabIndex = 60;
            this.buttonReport.UseVisualStyleBackColor = false;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.Transparent;
            this.buttonDone.FlatAppearance.BorderSize = 0;
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone.Image = global::BD_UI.Properties.Resources.Done_115_461;
            this.buttonDone.Location = new System.Drawing.Point(368, 486);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(115, 49);
            this.buttonDone.TabIndex = 59;
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = global::BD_UI.Properties.Resources.Xgradient;
            this.pictureBoxClose.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(18, 19);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 31;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // SalesHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 555);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBoxClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesHistoryForm";
            this.Text = "SalesHistoryForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxCurrentOrders;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxCompletedOrders;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonReport;
    }
}