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
            var cars = databaseContext.Set<Cars>().Include(c => c.Model).Include(c => c.CarShowroom);
            foreach (Cars car in cars)
            {
                var model = databaseContext.Models.Include(m => m.Brand).First(m => m == car.Model);
                var brand = databaseContext.CarBrands.First(b => b == model.Brand);
                comboBoxCar.Items.Add(
                    car.Id.ToString() + ". " + brand.Name + " " + model.Name + ", " + car.ProductionYear + " " + car.Body);
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
                    DocumentNumber = textBoxIDcustomer.Text
                };
                databaseContext.Clients.Add(client);
            }
            var car = databaseContext.Cars.Include(c => c.CarShowroom).FirstOrDefault(c =>
                Int32.Parse(comboBoxCar.SelectedItem.ToString().Substring(0, 1)) == c.Id);
            var showroom = databaseContext.CarShowrooms.FirstOrDefault(cs =>
                comboBoxShowroom.SelectedItem.ToString().Contains(cs.Name));
            if (car.CarShowroom != showroom)
            {
                MessageBox.Show("Wybrany samochód nie jest dostępny w salonie " + showroom.Name + "!");
            }
            else if (dateTimePickerDate1.Value > dateTimePickerDate2.Value)
            {
                MessageBox.Show("Wybrana data realizacji zamówienia jest błędna!");
            }
            else
            {
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
        }

        private void comboBoxCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var car = databaseContext.Cars.Include(c => c.CarShowroom).FirstOrDefault(c =>
                comboBoxCar.SelectedItem.ToString().Contains(c.Id.ToString()));
            var showroom = databaseContext.CarShowrooms.FirstOrDefault(cs => cs == car.CarShowroom);
            comboBoxShowroom.SelectedIndex = comboBoxShowroom.Items.IndexOf(car.CarShowroom.Name);
        }
    }
}
