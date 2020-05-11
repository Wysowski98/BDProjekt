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
    public partial class ShowModelBrandForm : Form
    {
        private DatabaseContext databaseContext;

        public ShowModelBrandForm()
        {
            DesignTimeDbContextFactory factory = new DesignTimeDbContextFactory();
            databaseContext = factory.CreateDbContext();
            InitializeComponent();
            FillListBoxes();
        }

        private void FillListBoxes()
        {
            listBoxBrands.Items.Clear();
            var brands = databaseContext.Set<CarBrands>();
            foreach (CarBrands brand in brands)
            {
                listBoxBrands.Items.Add(brand.Name);
            }

            listBoxModels.Items.Clear();
            var models = databaseContext.Set<Models>();
            foreach (Models model in models)
            {
                listBoxModels.Items.Add(model.Name);
            }

            listBoxJobs.Items.Clear();
            var jobs = databaseContext.Set<Jobs>();
            foreach(Jobs job in jobs)
            {
                listBoxJobs.Items.Add(job.Name);
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

        private void listBoxBrands_SelectedIndexChanged(object sender, EventArgs e)
        {
            var brand = databaseContext.CarBrands.First(b =>
                listBoxBrands.SelectedItem.ToString().Contains(b.Name));
            textBoxBrandID.Text = brand.Id.ToString();
            textBoxBrandName.Text = brand.Name;
        }

        private void listBoxModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            var model = databaseContext.Models.First(m =>
                listBoxModels.SelectedItem.ToString().Contains(m.Name));
            textBoxModelID.Text = model.Id.ToString();
            textBoxModelBrandID.Text = model.Brand.Id.ToString();
            textBoxModelName.Text = model.Name;
        }

        private void listBoxJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            var job = databaseContext.Jobs.First(j =>
                listBoxJobs.SelectedItem.ToString().Contains(j.Name));
            textBoxJobID.Text = job.Id.ToString();
            textBoxJobName.Text = job.Name;
        }
    }
}
