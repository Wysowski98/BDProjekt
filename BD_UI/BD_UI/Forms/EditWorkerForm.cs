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
    public partial class EditWorkerForm : Form
    {
        private DatabaseContext databaseContext;

        public EditWorkerForm()
        {
            DesignTimeDbContextFactory fac = new DesignTimeDbContextFactory();
            databaseContext = fac.CreateDbContext();
            InitializeComponent();
            FillListBox();
            FillComboBoxes();
        }

        private void FillListBox()
        {
            listBoxWorkers.Items.Clear();

            var employees = databaseContext.Set<Employees>().Include(em => em.CarShowroom).Include(em => em.Job);
            foreach(Employees employee in employees)
            {
                listBoxWorkers.Items.Add(employee.FirstName + " " + employee.LastName);
            }
        }

        private void FillComboBoxes()
        {
            var showrooms = databaseContext.Set<CarShowrooms>();
            var jobs = databaseContext.Set<Jobs>();

            foreach(CarShowrooms showroom in showrooms)
            {
                comboBoxShowroom.Items.Add(showroom.Address);
            }
            foreach(Jobs job in jobs)
            {
                comboBoxWorkerPosition.Items.Add(job.Name);
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            var employee = databaseContext.Employees.First(em =>
                listBoxWorkers.SelectedItem.ToString().Contains(em.FirstName)
                && listBoxWorkers.SelectedItem.ToString().Contains(em.LastName));

            if (!String.IsNullOrWhiteSpace(textBoxFirstName.Text))
            {
                if(!String.IsNullOrWhiteSpace(textBoxLastName.Text))
                {
                    if (!String.IsNullOrWhiteSpace(textBoxID.Text))
                    {
                        if (!String.IsNullOrWhiteSpace(textBoxPhoneNumber.Text))
                        {
                            employee.FirstName = textBoxFirstName.Text;
                            employee.LastName = textBoxLastName.Text;
                            employee.DoucmentNumber = textBoxID.Text;
                            employee.PhoneNumber = textBoxPhoneNumber.Text;
                        }
                    }
                }
            }
            if(comboBoxShowroom.SelectedIndex > -1)
            {
                var showroom = databaseContext.CarShowrooms.FirstOrDefault(cs =>
                    comboBoxShowroom.SelectedItem.ToString().Contains(cs.Address));
                employee.CarShowroom = showroom;
            }
            if(comboBoxWorkerPosition.SelectedIndex > -1)
            {
                var job = databaseContext.Jobs.FirstOrDefault(j =>
                    comboBoxWorkerPosition.SelectedItem.ToString().Contains(j.Name));
                employee.Job = job;
            }
            if (!String.IsNullOrWhiteSpace(textBoxUsername.Text))
            {
                var account = databaseContext.Accounts.First(acc => acc.Employee == employee);
                account.Login = textBoxUsername.Text;
                if(!String.IsNullOrWhiteSpace(textBoxPassword1.Text) && !String.IsNullOrWhiteSpace(textBoxPassword2.Text))
                {
                    if(textBoxPassword1.Text == textBoxPassword2.Text)
                    {
                        account.Password = textBoxPassword1.Text;
                    }
                }
            }
            databaseContext.SaveChanges();
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var employee = databaseContext.Employees.First(em =>
                listBoxWorkers.SelectedItem.ToString().Contains(em.FirstName)
                && listBoxWorkers.SelectedItem.ToString().Contains(em.LastName));
            databaseContext.Employees.Remove(employee);
            databaseContext.SaveChanges();
            this.Close();
        }

        private void listBoxWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var employee = databaseContext.Employees.First(em =>
                listBoxWorkers.SelectedItem.ToString().Contains(em.FirstName)
                && listBoxWorkers.SelectedItem.ToString().Contains(em.LastName));
            var showroom = databaseContext.CarShowrooms.FirstOrDefault(cs => cs == employee.CarShowroom);
            var job = databaseContext.Jobs.FirstOrDefault(j => j == employee.Job);
            var account = databaseContext.Accounts.First(acc => acc.Employee == employee);

            textBoxFirstName.Text = employee.FirstName;
            textBoxLastName.Text = employee.LastName;
            textBoxID.Text = employee.DoucmentNumber;
            textBoxPhoneNumber.Text = employee.PhoneNumber;
            comboBoxShowroom.SelectedIndex = comboBoxShowroom.Items.IndexOf(showroom.Address);
            comboBoxWorkerPosition.SelectedIndex = comboBoxWorkerPosition.Items.IndexOf(job.Name);
            textBoxUsername.Text = account.Login;
        }
    }
}
