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
    public partial class EditCarForm : Form
    {
        private DatabaseContext dbContext;

        private bool checkEntries()
        {
            if((!String.IsNullOrWhiteSpace(textBoxPrice.Text)))
            {
                if ((!String.IsNullOrWhiteSpace(textBoxYear.Text)))
                {
                    if ((!String.IsNullOrWhiteSpace(textBoxEngine.Text)))
                    {
                        if ((!String.IsNullOrWhiteSpace(textBoxBodyCar.Text)))
                        {
                            if(comboBoxBrand.SelectedIndex > -1)
                            {
                                if (comboBoxModel.SelectedIndex > -1)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }

        public EditCarForm()
        {
            InitializeComponent();
            listBoxCars.ScrollAlwaysVisible = true;
            DesignTimeDbContextFactory factory = new DesignTimeDbContextFactory();
            dbContext = factory.CreateDbContext();
            listBoxCars.Items.Clear();

            var cars = dbContext.Set<Cars>().Include(c => c.CarShowroom).Include(c => c.Model);
            foreach (Cars car in cars)
            {              
                listBoxCars.Items.Add(car.Model.Name + ", " + car.ProductionYear + ", " + car.Body + ", ID: " + car.Id);
            }
            var brands = dbContext.Set<CarBrands>();
            foreach(CarBrands brand in brands)
            {
                comboBoxBrand.Items.Add(brand.Name);
            }
            var showrooms = dbContext.Set<CarShowrooms>();
            foreach(CarShowrooms cs in showrooms)
            {
                comboBoxAdress.Items.Add(cs.Address + ", " + cs.Name);
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (listBoxCars.SelectedIndex > -1)
            {
                if (checkEntries())
                {
                    Cars car = dbContext.Set<Cars>().Include(c => c.CarShowroom).Include(c => c.Model).ThenInclude(m => m.Brand).FirstOrDefault(c => c.Id == Int32.Parse(listBoxCars.SelectedItem.ToString().Split(',')[3].Split(':')[1].Substring(1)));
                    car.Body = textBoxBodyCar.Text;
                    car.EngineCapacity = Decimal.Parse(textBoxEngine.Text);
                    car.Price = Decimal.Parse(textBoxPrice.Text);
                    car.ProductionYear = Int32.Parse(textBoxYear.Text);
                    car.Model = dbContext.Set<Models>().Include(m => m.Brand).FirstOrDefault(m => m.Name == comboBoxModel.Text && m.Brand.Name == comboBoxBrand.Text);

                    if (comboBoxAdress.SelectedIndex > -1)
                        car.CarShowroom = dbContext.Set<CarShowrooms>().FirstOrDefault(cs => cs.Address == comboBoxAdress.SelectedItem.ToString().Split(',')[0]);
                    else
                        car.CarShowroom = null;

                    dbContext.SaveChanges();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nie wszystkie wymagane pola zostały uzupełnione!", "Błąd modyfikowania pojazdu.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano pojazdu do modyfikacji!", "Błąd modyfikowania pojazdu.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxCars.SelectedIndex > -1)
            {
                Cars car = dbContext.Set<Cars>().FirstOrDefault(c => c.Id == Int32.Parse(listBoxCars.SelectedItem.ToString().Split(',')[3].Split(':')[1].Substring(1)));
                dbContext.Set<Cars>().Remove(car);
                dbContext.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nie wybrano pojazdu do usunięcia!", "Błąd usuwania pojazdu.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxModel.Items.Clear();
            var brandName = comboBoxBrand.SelectedItem.ToString();
            var models = dbContext.Set<Models>().Include(m => m.Brand);
            foreach(Models model in models)
            {
                if (model.Brand.Name == brandName)
                    comboBoxModel.Items.Add(model.Name);
            }
        }

        private void listBoxCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cars = dbContext.Set<Cars>().Include(c => c.CarShowroom).Include(c => c.Model).ThenInclude(m => m.Brand);
            
            Cars car = cars.FirstOrDefault(
            cr => 
            cr.Model.Name == listBoxCars.SelectedItem.ToString().Split(',')[0] && 
            cr.ProductionYear == Int32.Parse(listBoxCars.SelectedItem.ToString().Split(',')[1].Substring(1)) && 
            cr.Body == listBoxCars.SelectedItem.ToString().Split(',')[2].Substring(1)
            );

            textBoxBodyCar.Text = car.Body;
            textBoxEngine.Text = car.EngineCapacity.ToString();
            textBoxYear.Text = car.ProductionYear.ToString();
            textBoxPrice.Text = car.Price.ToString();
            foreach(object x in comboBoxAdress.Items)
            {
                if (car.CarShowroom != null)
                {
                    if (x.ToString().Split(',')[0] == car.CarShowroom.Address)
                    {
                        comboBoxAdress.SelectedItem = x;
                    }
                }
                else
                    comboBoxAdress.SelectedIndex = -1;
            }
            foreach (object x in comboBoxBrand.Items)
            {
                if (x.ToString() == car.Model.Brand.Name)
                {
                        comboBoxBrand.SelectedItem = x;
                }              
            }
            foreach (object x in comboBoxModel.Items)
            {
                if (x.ToString() == car.Model.Name)
                {
                    comboBoxModel.SelectedItem = x;
                }
            }
        }
    }
}
