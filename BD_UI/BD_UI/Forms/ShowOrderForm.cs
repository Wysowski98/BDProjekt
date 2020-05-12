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
    public partial class ShowOrderForm : Form
    {
        private DatabaseContext databaseContext;

        public ShowOrderForm()
        {
            DesignTimeDbContextFactory factory = new DesignTimeDbContextFactory();
            databaseContext = factory.CreateDbContext();
            InitializeComponent();
            FillListBox();
        }

        private void FillListBox()
        {
            listBoxOrders.Items.Clear();

            var orders = databaseContext.Set<Orders>();
            foreach(Orders order in orders)
            {
                listBoxOrders.Items.Add("Order " + order.Id);
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxServices.Items.Clear();

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
            textBoxCar.Text = brand.Name + " " + model.Name;
            textBoxShowroom.Text = showroom.Name;
        }
    }
}
