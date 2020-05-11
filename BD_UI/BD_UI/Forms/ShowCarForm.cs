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
            var cars = databaseContext.Set<Cars>();
            foreach(Cars car in cars)
            {
                listBoxCars.Items.Add(car.Model.Brand.Name + car.Model.Name);
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
