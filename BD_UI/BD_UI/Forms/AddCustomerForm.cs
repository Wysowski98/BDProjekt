using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BD_UI.Database;
using BD_UI.Database.Domain;

namespace BD_UI
{
    public partial class AddCustomerForm : Form
    {
        private DatabaseContext db;

        public AddCustomerForm()
        {
            InitializeComponent();
            DesignTimeDbContextFactory fac = new DesignTimeDbContextFactory();
            db = fac.CreateDbContext();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var clients = db.Set<Clients>();
            clients.Add(new Clients
            {
                FirstName = textBoxName.Text,
                LastName = textBoxLastName.Text,
                DocumentNumber = textBoxID.Text,
                PhoneNumber = textBoxPhoneNumber.Text
            });
            db.SaveChanges();
            this.Close();
        }
    }
}
