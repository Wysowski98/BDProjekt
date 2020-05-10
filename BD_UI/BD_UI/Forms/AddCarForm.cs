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
    public partial class AddCarForm : Form
    {
        private DatabaseContext databaseContext;
        public AddCarForm()
        {
            DesignTimeDbContextFactory factory = new DesignTimeDbContextFactory();
            databaseContext = factory.CreateDbContext();
            InitializeComponent();
            fillComboBoxes();
        }

        private void fillComboBoxes()
        {
            var brands = databaseContext.Set<CarBrands>();
            foreach (CarBrands carBrand in brands)
            {
                comboBoxBrand.Items.Add(carBrand.Name);
            }

            var showrooms = databaseContext.Set<CarShowrooms>();
            foreach (CarShowrooms showroom in showrooms)
            {
                comboBoxShowroomAdress.Items.Add(showroom.Address);
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Submit data
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var car = databaseContext.Set<Cars>();
            car.Add(new Cars
            {
                ProductionYear = int.Parse(textBoxYear.Text),
                Body = textBoxBodyCar.Text,
                EngineCapacity = Decimal.Parse(textBoxEngine.Text),
                Price = Decimal.Parse(textBoxPrice.Text),
                Model = databaseContext.Set<Models>()
                .Where(model => model.Name == comboBoxModel.Text)
                .FirstOrDefault<Models>(),
                CarShowroom = databaseContext.Set<CarShowrooms>()
                .Where(showroom => showroom.Address == comboBoxShowroomAdress.Text)
                .FirstOrDefault<CarShowrooms>()
            });
            databaseContext.SaveChanges();

            this.Close();
        }

        // Set models of selected brand
        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxModel.Items.Clear();
            var models = databaseContext.Set<Models>().Where(model => model.Brand.Name == comboBoxBrand.Text);
            foreach (Models model in models)
            {
                comboBoxModel.Items.Add(model.Name);
            }
        }
    }
}
