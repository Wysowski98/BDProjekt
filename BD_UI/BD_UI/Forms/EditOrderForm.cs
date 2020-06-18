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
    public partial class EditOrderForm : Form
    {
        private DatabaseContext databaseContext;

        public EditOrderForm()
        {
            DesignTimeDbContextFactory factory = new DesignTimeDbContextFactory();
            databaseContext = factory.CreateDbContext();
            InitializeComponent();
            FillListBox();
            FillComboBoxes();
        }

        private void FillListBox()
        {
            listBoxOrders.Items.Clear();

            var orders = databaseContext.Set<Orders>();
            foreach (Orders order in orders)
            {
                listBoxOrders.Items.Add("Order " + order.Id);
            }
        }

        private void FillComboBoxes()
        {
            var cars = databaseContext.Set<Cars>().Include(c => c.Model).Include(c => c.CarShowroom);
            var showrooms = databaseContext.Set<CarShowrooms>();

            foreach(Cars car in cars)
            {
                var model = databaseContext.Models.Include(m => m.Brand).First(m => m == car.Model);
                var brand = databaseContext.CarBrands.First(b => b == model.Brand);
                comboBoxCar.Items.Add(car.Id.ToString() + ". " + brand.Name + " " + model.Name);
            }
            foreach(CarShowrooms showroom in showrooms)
            {
                comboBoxShowroom.Items.Add(showroom.Name);
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            var order = databaseContext.Orders.Include(o => o.Client).Include(o => o.Car).First(o =>
                listBoxOrders.SelectedItem.ToString().Contains(o.Id.ToString()));
            
            if (!String.IsNullOrWhiteSpace(textBoxOrderID.Text))
            {            
                String services = "";

                foreach (Object item in checkedListBoxServices.CheckedItems)
                {
                    services += (item.ToString() + ", ");
                }
                services.TrimEnd(',');

                if (!String.IsNullOrWhiteSpace(textBoxPrice.Text))
                {
                    order.Id = int.Parse(textBoxOrderID.Text);
                    order.Price = int.Parse(textBoxPrice.Text);
                    order.OrderDate = dateTimePickerDate1.Value;
                    order.RealizationDate = dateTimePickerDate2.Value;
                    order.AdditionalServices = services;
                }             
            }
            if (!String.IsNullOrWhiteSpace(textBoxFirstName.Text))
            {
                if (!String.IsNullOrWhiteSpace(textBoxLastName.Text))
                {
                    if (!String.IsNullOrWhiteSpace(textBoxCustomerID.Text))
                    {
                        if (!String.IsNullOrWhiteSpace(textBoxPhoneNumber.Text))
                        {
                            var client = databaseContext.Clients.FirstOrDefault(c =>
                                c == order.Client);
                            client.FirstName = textBoxFirstName.Text;
                            client.LastName = textBoxLastName.Text;
                            client.DocumentNumber = textBoxCustomerID.Text;
                            client.PhoneNumber = textBoxPhoneNumber.Text;
                        }
                    }
                }
            }
            if(comboBoxCar.SelectedIndex > -1)
            {
                if(comboBoxShowroom.SelectedIndex > -1)
                {
                    var car = databaseContext.Cars.First(c =>
                        comboBoxCar.SelectedItem.ToString().Substring(0, 2).Contains(c.Id.ToString()));
                    var showroom = databaseContext.CarShowrooms.First(cs => cs == car.CarShowroom);
                }
            }
            databaseContext.SaveChanges();
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var order = databaseContext.Orders.First(o =>
                listBoxOrders.SelectedItem.ToString().Contains(o.Id.ToString()));
            databaseContext.Orders.Remove(order);
            databaseContext.SaveChanges();
            this.Close();
        }

        private void listBoxOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

            var order = databaseContext.Orders.Include(o => o.Car).Include(o => o.Client).First(o =>
                listBoxOrders.SelectedItem.ToString().Contains(o.Id.ToString()));
            var client = databaseContext.Clients.First(c => c == order.Client);
            var car = databaseContext.Cars.Include(c => c.Model).Include(c => c.CarShowroom).First(c => c == order.Car);
            var model = databaseContext.Models.Include(m => m.Brand).First(m => m == car.Model);
            var brand = databaseContext.CarBrands.First(b => b == model.Brand);
            var showroom = databaseContext.CarShowrooms.First(cs => cs == car.CarShowroom);

            textBoxOrderID.Text = order.Id.ToString();
            textBoxPrice.Text = order.Price.ToString();
            textBoxFirstName.Text = client.FirstName;
            textBoxLastName.Text = client.LastName;
            textBoxCustomerID.Text = client.DocumentNumber;
            textBoxPhoneNumber.Text = client.PhoneNumber;
            comboBoxCar.SelectedIndex = comboBoxCar.Items.IndexOf(car.Id.ToString() + " " + brand.Name + " " + model.Name);
            comboBoxShowroom.SelectedIndex = comboBoxShowroom.Items.IndexOf(showroom.Name);          
        }

        private void comboBoxCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var car = databaseContext.Cars.Include(c => c.CarShowroom).First(c =>
                comboBoxCar.SelectedItem.ToString().Substring(0, 2).Contains(c.Id.ToString()));
            var showroom = databaseContext.CarShowrooms.First(cs => cs == car.CarShowroom);
            comboBoxShowroom.SelectedIndex = comboBoxShowroom.Items.IndexOf(showroom.Name);
        }

        private void comboBoxShowroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCar.Items.Clear();
            var showroom = databaseContext.CarShowrooms.First(cs =>
                comboBoxShowroom.SelectedItem.ToString().Contains(cs.Name));
            var cars = databaseContext.Set<Cars>().Include(c => c.CarShowroom).Where(c => c.CarShowroom == showroom);
            foreach(Cars car in cars)
            {
                var model = databaseContext.Models.Include(m => m.Brand).First(m => m == car.Model);
                var brand = databaseContext.CarBrands.First(b => b == model.Brand);
                comboBoxCar.Items.Add(car.Id.ToString() + ". " + brand.Name + " " + model.Name);
            }
        }
    }
}
