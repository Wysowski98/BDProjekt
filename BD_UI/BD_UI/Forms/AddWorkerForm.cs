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

namespace BD_UI
{
    public partial class AddWorkerForm : Form
    {
        private DatabaseContext databaseContext;

        public AddWorkerForm()
        {
            DesignTimeDbContextFactory fac = new DesignTimeDbContextFactory();
            databaseContext = fac.CreateDbContext();
            InitializeComponent();
            FillListBoxes();
        }

        private void FillListBoxes()
        {
            var showrooms = databaseContext.Set<CarShowrooms>();
            var jobs = databaseContext.Set<Jobs>();

            foreach (CarShowrooms showroom in showrooms)
            {
                comboBoxShowroom.Items.Add(showroom.Address);
            }
            foreach (Jobs job in jobs)
            {
                if (job.Name != "Administrator")
                    comboBoxWorkerPosition.Items.Add(job.Name);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBoxName.Text))
            {
                if (!String.IsNullOrWhiteSpace(textBoxLastName.Text))
                {
                    if (!String.IsNullOrWhiteSpace(textBoxPhoneNumber.Text))
                    {
                        if (!String.IsNullOrWhiteSpace(textBoxID.Text))
                        {
                            if (!String.IsNullOrWhiteSpace(textBoxUsername.Text))
                            {
                                if (!String.IsNullOrWhiteSpace(textBoxPassword1.Text))
                                {
                                    if (!String.IsNullOrWhiteSpace(textBoxPassword2.Text))
                                    {
                                        if (textBoxPassword1.Text == textBoxPassword2.Text)
                                        {
                                            var emp = databaseContext.Set<Employees>();
                                            var showRooms = databaseContext.Set<CarShowrooms>();
                                            var showRoom = showRooms.Where(sr => sr.Address == comboBoxShowroom.Text).FirstOrDefault<CarShowrooms>();
                                            var jobs = databaseContext.Set<Jobs>();
                                            var job = jobs.Where(j => j.Name == comboBoxWorkerPosition.Text).FirstOrDefault<Jobs>();

                                            emp.Add(new Employees { FirstName = textBoxName.Text, LastName = textBoxLastName.Text, PhoneNumber = textBoxPhoneNumber.Text, CarShowroom = showRoom, Job = job, DoucmentNumber = textBoxID.Text });
                                            databaseContext.SaveChanges();

                                            var accs = databaseContext.Set<Accounts>();
                                            accs.Add(new Accounts
                                            {
                                                Login = textBoxUsername.Text,
                                                Password = textBoxPassword1.Text,
                                                Employee = databaseContext.Employees.FirstOrDefault(em => em.DoucmentNumber == textBoxID.Text)
                                            });

                                            databaseContext.SaveChanges();

                                            this.Close();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }         
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}