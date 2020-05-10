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
        public AddWorkerForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DesignTimeDbContextFactory fac = new DesignTimeDbContextFactory();
            using (var db = fac.CreateDbContext())
            {
                var emp = db.Set<Employees>();              
                emp.Add(new Employees { FirstName = textBoxName.Text, LastName = textBoxLastName.Text });

                db.SaveChanges();
            }
            
            this.Close();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
