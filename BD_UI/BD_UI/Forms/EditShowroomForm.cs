﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_UI
{
    public partial class EditShowroomForm : Form
    {
        public EditShowroomForm()
        {
            InitializeComponent();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
