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
    public partial class ShowCarForm : Form
    {
        private DatabaseContext databaseContext;

        public ShowCarForm()
        {
            DesignTimeDbContextFactory factory = new DesignTimeDbContextFactory();
            databaseContext = factory.CreateDbContext();
            InitializeComponent();
            FillListBox();
        }

        private void FillListBox()
        {
            listBoxCars.Items.Clear();

            var cars = databaseContext.Set<Cars>().Include(c => c.Model);
            var models = databaseContext.Set<Models>().Include(m => m.Brand);
            foreach(Cars car in cars)
            {
                var model = models.First(m => m == car.Model);
                listBoxCars.Items.Add(car.Id + ". " + model.Brand.Name + " " + car.Model.Name);
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

        private void listBoxCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            var car = databaseContext.Cars.Include(c => c.CarShowroom).First(c =>
                listBoxCars.SelectedItem.ToString().Substring(0, 2)
                .Contains(c.Id.ToString()));
            var model = databaseContext.Models.First(m => m == car.Model);
            var brand = databaseContext.CarBrands.First(b => b == model.Brand);
            var showroom = databaseContext.CarShowrooms.First(cs => cs == car.CarShowroom);

            textBoxIDcar.Text = car.Id.ToString();
            textBoxPrice.Text = car.Price.ToString();
            textBoxYear.Text = car.ProductionYear.ToString();
            textBoxEngine.Text = car.EngineCapacity.ToString();
            textBoxBodyCar.Text = car.Body;
            textBoxModel.Text = model.Name;
            textBoxBrand.Text = brand.Name;
            textBoxShowroom.Text = showroom.Name;
        }
    }
}
