using BD_UI.Database;
using BD_UI.Database.Domain;
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
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DesignTimeDbContextFactory fac = new DesignTimeDbContextFactory();
            using (var db = fac.CreateDbContext())
            {
                var client = db.Set<Clients>();
                client.Add(new Clients
                {
                    FirstName = textBoxName.Text,
                    LastName = textBoxLastName.Text,
                    PhoneNumber = textBoxPhoneNumber.Text
                });
            }
            this.Close();
        }
    }
}
