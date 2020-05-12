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
    public partial class ShowCustomerForm : Form
    {
        private DatabaseContext databaseContext;

        public ShowCustomerForm()
        {
            DesignTimeDbContextFactory factory = new DesignTimeDbContextFactory();
            databaseContext = factory.CreateDbContext();
            InitializeComponent();
            FillListBox();
        }

        private void FillListBox()
        {
            listBoxCustomers.Items.Clear();
            var clients = databaseContext.Set<Clients>();
            foreach (Clients client in clients)
            {
                listBoxCustomers.Items.Add(client.FirstName + " " + client.LastName);
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var client = databaseContext.Clients.First(c =>
                listBoxCustomers.SelectedItem.ToString().Contains(c.FirstName)
                && listBoxCustomers.SelectedItem.ToString().Contains(c.LastName));

            textBoxFirstName.Text = client.FirstName;
            textBoxLastName.Text = client.LastName;
            textBoxID.Text = client.DocumentNumber;
            textBoxPhoneNumber.Text = client.PhoneNumber;
        }
    }
}
