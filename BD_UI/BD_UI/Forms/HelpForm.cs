using System;
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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }
    
        private void labelLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Navigate to URL
            System.Diagnostics.Process.Start("https://docs.google.com/document/d/1twMd3HQdyqI8LphJqZGLgKNV-pNTRzPnnDcCbF8RWm4/edit?fbclid=IwAR3-qqo6azAgZPmyZiDd99qJrLVKvqIxFATYKl0l8vEXqy58IZ7cTVzrdk8");
        }
    }
}
