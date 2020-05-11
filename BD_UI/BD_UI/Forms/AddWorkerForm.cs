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
        private DatabaseContext db;

        public AddWorkerForm()
        {
            InitializeComponent();
            DesignTimeDbContextFactory fac = new DesignTimeDbContextFactory();
            db = fac.CreateDbContext();

            var showRooms = db.Set<CarShowrooms>();
            foreach (CarShowrooms cs in showRooms)
            {
                comboBoxShowroom.Items.Add(cs.Address);
            }
            var jbs = db.Set<Jobs>();
            foreach (Jobs j in jbs)
            {
                if (j.Name != "Administrator")
                    comboBoxWorkerPosition.Items.Add(j.Name);
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
                                            var emp = db.Set<Employees>();
                                            var showRooms = db.Set<CarShowrooms>();
                                            var showRoom = showRooms.Where(sr => sr.Address == comboBoxShowroom.Text).FirstOrDefault<CarShowrooms>();
                                            var jobs = db.Set<Jobs>();
                                            var job = jobs.Where(j => j.Name == comboBoxWorkerPosition.Text).FirstOrDefault<Jobs>();

                                            emp.Add(new Employees { FirstName = textBoxName.Text, LastName = textBoxLastName.Text, PhoneNumber = textBoxPhoneNumber.Text, CarShowroom = showRoom, Job = job, DoucmentNumber = textBoxID.Text });
                                            db.SaveChanges();

                                            var accs = db.Set<Accounts>();
                                            accs.Add(new Accounts
                                            {
                                                Login = textBoxUsername.Text,
                                                Password = textBoxPassword1.Text,
                                                Employee = db.Employees.FirstOrDefault(em => em.DoucmentNumber == textBoxID.Text)
                                            });

                                            db.SaveChanges();

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