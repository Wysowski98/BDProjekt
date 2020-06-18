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
    public partial class ShowShowroomForm : Form
    {
        private DatabaseContext databaseContext;

        public ShowShowroomForm()
        {
            DesignTimeDbContextFactory factory = new DesignTimeDbContextFactory();
            databaseContext = factory.CreateDbContext();
            InitializeComponent();
            FillListBoxes();
        }

        private void FillListBoxes()
        {
            listBoxShowrooms.Items.Clear();
            listBoxCars.Items.Clear();
            listBoxWorkers.Items.Clear();

            var showrooms = databaseContext.Set<CarShowrooms>();
            foreach(CarShowrooms showroom in showrooms)
            {
                listBoxShowrooms.Items.Add(showroom.Name);
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

        private void listBoxShowrooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxCars.Items.Clear();
            listBoxWorkers.Items.Clear();

            var showroom = databaseContext.CarShowrooms.First(cs =>
                listBoxShowrooms.SelectedItem.ToString().Contains(cs.Name));
            var employees = databaseContext.Employees.Where(em => em.CarShowroom == showroom);
            var cars = databaseContext.Cars.Include(c => c.Model).Where(c => c.CarShowroom == showroom);

            textBoxName.Text = showroom.Name;
            textBoxAdress.Text = showroom.Address;
            textBoxID.Text = showroom.Id.ToString();
            foreach(Cars car in cars)
            {
                var model = databaseContext.Models.Include(m => m.Brand).First(m => m == car.Model);
                var brand = databaseContext.CarBrands.First(b => b == model.Brand);
                listBoxCars.Items.Add(brand.Name + " " + model.Name);
            }
            foreach(Employees employee in employees)
            {
                listBoxWorkers.Items.Add(employee.FirstName + " " + employee.LastName);
            }
        }
    }
}
