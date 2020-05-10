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
            var emp = db.Set<Employees>();
            var showRooms = db.Set<CarShowrooms>();
            var showRoom = showRooms.Where(sr => sr.Address == comboBoxShowroom.Text).FirstOrDefault<CarShowrooms>();
            var jobs = db.Set<Jobs>();
            var job = jobs.Where(j => j.Name == comboBoxWorkerPosition.Text).FirstOrDefault<Jobs>();
            emp.Add(new Employees { FirstName = textBoxName.Text, LastName = textBoxLastName.Text, PhoneNumber = textBoxPhoneNumber.Text, CarShowroom = showRoom, Job = job });

            db.SaveChanges();

            this.Close();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}