using BD_UI.Database;
using BD_UI.Database.Domain;
using Microsoft.EntityFrameworkCore;
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
    public partial class AddOrderForm : Form
    {
        private DatabaseContext databaseContext;

        public AddOrderForm()
        {
            DesignTimeDbContextFactory factory = new DesignTimeDbContextFactory();
            databaseContext = factory.CreateDbContext();
            InitializeComponent();
            FillComboBoxes();
        }

        private void FillComboBoxes()
        {
            var clients = databaseContext.Set<Clients>();
            if(clients.Any())
            {
                foreach (Clients client in clients)
                {
                    comboBoxCustomer.Items.Add(client.FirstName + " " + client.LastName);
                }
            }

            var models = databaseContext.Set<Models>().Include(m => m.Brand);
            foreach (Models model in models)
            {
                comboBoxCar.Items.Add(model.Brand.Name + " " + model.Name);
            }

            var showrooms = databaseContext.Set<CarShowrooms>();
            foreach (CarShowrooms showroom in showrooms)
            {
                comboBoxShowroom.Items.Add(showroom.Name);
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Clients client;
            if (comboBoxCustomer.SelectedIndex > -1)
            {
                client = databaseContext.Clients.First(c =>
                    comboBoxCustomer.SelectedItem.ToString().Contains(c.FirstName) &&
                    comboBoxCustomer.SelectedItem.ToString().Contains(c.LastName));
            }
            else
            {
                client = new Clients
                {
                    FirstName = textBoxName.Text,
                    LastName = textBoxLastName.Text,
                    PhoneNumber = textBoxPhoneNumber.Text,
                    DocumentNumber = int.Parse(textBoxIDcustomer.Text)
                };
            }
            var car = databaseContext.Cars.FirstOrDefault(c => comboBoxCar.SelectedItem.ToString().Contains(c.Model.Name));

            if (checkedListServices.CheckedItems.Count > 0)
            {
                String services = "";

                foreach (Object item in checkedListServices.CheckedItems)
                {
                    services += (item.ToString() + ", ");
                }
                services.TrimEnd(',');

                databaseContext.Orders.Add(new Orders
                {
                    Car = car,
                    Client = client,
                    Price = int.Parse(textBoxPrice.Text),
                    OrderDate = dateTimePickerDate1.Value,
                    RealizationDate = dateTimePickerDate2.Value,
                    AdditionalServices = services
                });
            }
            else
            {
                databaseContext.Orders.Add(new Orders
                {
                    Car = car,
                    Client = client,
                    Price = int.Parse(textBoxPrice.Text),
                    OrderDate = dateTimePickerDate1.Value,
                    RealizationDate = dateTimePickerDate2.Value
                });
            }
            databaseContext.SaveChanges();

            this.Close();
        }

        private void comboBoxCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxShowroom.Items.Clear();
            var selectedCar = databaseContext.Cars.FirstOrDefault(c => comboBoxCar.SelectedItem.ToString().Contains(c.Model.Name));
            var showrooms = databaseContext.Set<CarShowrooms>().Where(showroom => showroom.Cars.Contains(selectedCar));
            foreach(CarShowrooms showroom in showrooms)
            {
                comboBoxShowroom.Items.Add(showroom.Name);
            }
        }
    }
}
