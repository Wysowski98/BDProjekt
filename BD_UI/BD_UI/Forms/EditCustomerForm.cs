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
using Microsoft.EntityFrameworkCore;

namespace BD_UI
{
    public partial class EditCustomerForm : Form
    {
        private DatabaseContext databaseContext;

        private bool checkEntries()
        {
            if ((!String.IsNullOrWhiteSpace(textBoxLastName.Text)))
            {
                if ((!String.IsNullOrWhiteSpace(textBoxName.Text)))
                {
                    if ((!String.IsNullOrWhiteSpace(textBoxIDcard.Text)))
                    {
                        if ((!String.IsNullOrWhiteSpace(textBoxPhoneNumber.Text)))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public EditCustomerForm()
        {
            InitializeComponent();
            DesignTimeDbContextFactory factory = new DesignTimeDbContextFactory();
            databaseContext = factory.CreateDbContext();
            listBoxCustomers.Items.Clear();

            var customers = databaseContext.Set<Clients>();
            foreach(Clients customer in customers)
            {
                listBoxCustomers.Items.Add(customer.LastName + ", " + customer.FirstName + ", " + customer.DocumentNumber + ", " + customer.PhoneNumber + ", ID: " + customer.Id);
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if(listBoxCustomers.SelectedIndex > -1)
            {
                if(checkEntries())
                {
                    Clients customer = databaseContext.Set<Clients>().FirstOrDefault(cl => cl.Id == Int32.Parse(listBoxCustomers.SelectedItem.ToString().Split(',')[4].Split(':')[1].Substring(1)));
                    customer.DocumentNumber = textBoxIDcard.Text;
                    customer.FirstName = textBoxName.Text;
                    customer.LastName = textBoxLastName.Text;
                    customer.PhoneNumber = textBoxPhoneNumber.Text;
                    databaseContext.SaveChanges();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nie wszystkie wymagane pola zostały uzupełnione!", "Błąd modyfikowania klienta.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano klienta do modyfikacji!", "Błąd modyfikowania klienta.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxCustomers.SelectedIndex > -1)
            {
                Clients customer = databaseContext.Set<Clients>().FirstOrDefault(cl => cl.Id == Int32.Parse(listBoxCustomers.SelectedItem.ToString().Split(',')[4].Split(':')[1].Substring(1)));
                databaseContext.Set<Clients>().Remove(customer);
                databaseContext.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nie wybrano klienta do usunięcia!", "Błąd usuwania klienta.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clients customer = databaseContext.Set<Clients>().FirstOrDefault(cl => cl.Id == Int32.Parse(listBoxCustomers.SelectedItem.ToString().Split(',')[4].Split(':')[1].Substring(1)));
            textBoxIDcard.Text = customer.DocumentNumber;
            textBoxLastName.Text = customer.LastName;
            textBoxName.Text = customer.FirstName;
            textBoxPhoneNumber.Text = customer.PhoneNumber;
        }
    }
}
