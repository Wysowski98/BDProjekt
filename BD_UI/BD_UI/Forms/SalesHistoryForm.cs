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
    public partial class SalesHistoryForm : Form
    {
        private DatabaseContext databaseContext;

        public SalesHistoryForm()
        {
            DesignTimeDbContextFactory factory = new DesignTimeDbContextFactory();
            databaseContext = factory.CreateDbContext();
            InitializeComponent();
            FillListBoxes();
        }

        private void FillListBoxes()
        {
            listBoxCurrentOrders.Items.Clear();
            listBoxCompletedOrders.Items.Clear();

            var orders = databaseContext.Set<Orders>().Include(o => o.Car);
            foreach(Orders order in orders)
            {
                var car = databaseContext.Cars.Include(c => c.Model).First(c => c == order.Car);
                var model = databaseContext.Models.Include(m => m.Brand).First(m => m == car.Model);
                var brand = databaseContext.CarBrands.First(b => b == model.Brand);
                if (order.RealizationDate < DateTime.Now)
                {
                    listBoxCompletedOrders.Items.Add(
                        order.Id.ToString() + ". " + brand.Name + " " + model.Name + ", " + car.ProductionYear + ", " + car.Body);
                }
                else
                {
                    listBoxCurrentOrders.Items.Add(
                        order.Id.ToString() + ". " + brand.Name + " " + model.Name + ", " + car.ProductionYear + ", " + car.Body);
                }
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
    }
}
