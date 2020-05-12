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
    public partial class ShowWorkerForm : Form
    {
        private DatabaseContext databaseContext;

        public ShowWorkerForm()
        {
            DesignTimeDbContextFactory factory = new DesignTimeDbContextFactory();
            databaseContext = factory.CreateDbContext();
            InitializeComponent();
            FillListBox();
        }

        private void FillListBox()
        {
            listBoxWorkers.Items.Clear();
            var employees = databaseContext.Set<Employees>();
            foreach(Employees employee in employees)
            {
                listBoxWorkers.Items.Add(employee.FirstName + " " + employee.LastName);
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

        private void listBoxWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var employee = databaseContext.Employees
                .Include(em => em.CarShowroom).Include(em => em.Job).First(em =>
                listBoxWorkers.SelectedItem.ToString().Contains(em.FirstName)
                && listBoxWorkers.SelectedItem.ToString().Contains(em.LastName));
            var account = databaseContext.Accounts.First(a => a.Employee == employee);

            textBoxFirstName.Text = employee.FirstName;
            textBoxLastName.Text = employee.LastName;
            textBoxID.Text = employee.DoucmentNumber;
            textBoxPhoneNumber.Text = employee.PhoneNumber;
            textBoxShowroom.Text = employee.CarShowroom.Address;
            textBoxPosition.Text = employee.Job.Name;
            textBoxUsername.Text = account.Login;
        }
    }
}
