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
    public partial class EditModelBrandForm : Form
    {
        private DatabaseContext databaseContext;

        public EditModelBrandForm()
        {
            DesignTimeDbContextFactory fac = new DesignTimeDbContextFactory();
            databaseContext = fac.CreateDbContext();
            InitializeComponent();
            FillListBoxes();
        }

        private void FillListBoxes()
        {
            listBoxBrands.Items.Clear();
            listBoxModels.Items.Clear();
            listBoxJobs.Items.Clear();

            var brands = databaseContext.Set<CarBrands>();
            var models = databaseContext.Set<Models>();
            var jobs = databaseContext.Set<Jobs>();

            foreach (CarBrands brand in brands)
            {
                listBoxBrands.Items.Add(brand.Name);
            }
            foreach (Models model in models)
            {
                listBoxModels.Items.Add(model.Name);
            }
            foreach (Jobs job in jobs)
            {
                listBoxJobs.Items.Add(job.Name);
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(textBoxBrandID.Text))
            {
                if(!String.IsNullOrWhiteSpace(textBoxBrandName.Text))
                {
                    var brand = databaseContext.CarBrands.First(b =>
                        b.Name == listBoxBrands.SelectedItem.ToString());

                    brand.Id = int.Parse(textBoxBrandID.Text);
                    brand.Name = textBoxBrandName.Text;
                }
            }
            if (!String.IsNullOrWhiteSpace(textBoxJobID.Text))
            {
                if (!String.IsNullOrWhiteSpace(textBoxJobName.Text))
                {
                    var job = databaseContext.Jobs.First(j =>
                        j.Name == listBoxJobs.SelectedItem.ToString());

                    job.Id = int.Parse(textBoxJobID.Text);
                    job.Name = textBoxJobName.Text;
                }
            }
            if (!String.IsNullOrWhiteSpace(textBoxModelID.Text))
            {
                if (!String.IsNullOrWhiteSpace(textBoxModelName.Text))
                {
                    if (!String.IsNullOrWhiteSpace(textBoxModelBrandID.Text))
                    {
                        var model = databaseContext.Models.First(m =>
                            m.Name == listBoxModels.SelectedItem.ToString());
                        var brand = databaseContext.CarBrands.FirstOrDefault(b =>
                            b.Id == int.Parse(textBoxModelBrandID.Text));

                        model.Id = int.Parse(textBoxModelID.Text);
                        model.Name = textBoxModelName.Text;
                        model.Brand = brand;
                    }
                }
            }
            databaseContext.SaveChanges();
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(listBoxBrands.SelectedIndex > -1)
            {
                var brand = databaseContext.CarBrands.First(b =>
                    b.Name == listBoxBrands.SelectedItem.ToString());
                databaseContext.CarBrands.Remove(brand);
            }
            if (listBoxModels.SelectedIndex > -1)
            {
                var model = databaseContext.Models.First(m =>
                    m.Name == listBoxModels.SelectedItem.ToString());
                databaseContext.Models.Remove(model);
            }
            if (listBoxJobs.SelectedIndex > -1)
            {
                var job = databaseContext.Jobs.First(j =>
                    j.Name == listBoxJobs.SelectedItem.ToString());
                databaseContext.Jobs.Remove(job);
            }
            databaseContext.SaveChanges();
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
