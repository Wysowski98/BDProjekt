using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BD_UI.Database;
using BD_UI.Database.Domain;
using Microsoft.EntityFrameworkCore;

namespace BD_UI
{
    public partial class AddShowroomForm : Form
    {
        private DatabaseContext dbContext;

        public AddShowroomForm()
        {
            InitializeComponent();
            checkedListBoxWorkers.Items.Clear();
            checkedListBoxCars.Items.Clear();

            DesignTimeDbContextFactory fac = new DesignTimeDbContextFactory();
            dbContext = fac.CreateDbContext();

            var emps = dbContext.Set<Employees>().Include(e => e.CarShowroom);
            foreach (Employees emp in emps)
            {
                if(emp.CarShowroom == null)
                    checkedListBoxWorkers.Items.Add(emp.LastName + ", " + emp.FirstName);
            }
            var cars = dbContext.Set<Cars>().Include(c => c.CarShowroom).Include(c => c.Model);          
            foreach (Cars car in cars)
            {
                if(car.CarShowroom == null)
                    checkedListBoxCars.Items.Add(car.Model.Name + ", " + car.ProductionYear + ", " + car.Body);
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBoxShowroomName.Text))
            {
                if (!String.IsNullOrWhiteSpace(textBoxShowroomAdress.Text))
                {
                    dbContext.CarShowrooms.Add(new CarShowrooms
                    {
                        Name = textBoxShowroomName.Text,
                        Address = textBoxShowroomAdress.Text                        
                    });
                    dbContext.SaveChanges();

                    var emps = dbContext.Set<Employees>();
                    var cars = dbContext.Set<Cars>().Include(c => c.Model);
                    foreach (Object item in checkedListBoxWorkers.CheckedItems)
                    {
                        Employees emp = emps.FirstOrDefault(
                            em =>
                            em.LastName == item.ToString().Split(',')[0] && em.FirstName == item.ToString().Split(',')[1].Substring(1)
                            );

                        emp.CarShowroom = dbContext.CarShowrooms.FirstOrDefault(
                            cs =>
                            cs.Name == textBoxShowroomName.Text && cs.Address == textBoxShowroomAdress.Text
                            );
                    }
                    foreach (Object item in checkedListBoxCars.CheckedItems)
                    {
                        Cars car = cars.FirstOrDefault(
                            cr =>
                            cr.Model.Name == item.ToString().Split(',')[0] && cr.ProductionYear == Int32.Parse(item.ToString().Split(',')[1].Substring(1)) && cr.Body == item.ToString().Split(',')[2].Substring(1)
                            );
                        car.CarShowroom = dbContext.CarShowrooms.FirstOrDefault(
                           cs =>
                           cs.Name == textBoxShowroomName.Text && cs.Address == textBoxShowroomAdress.Text
                           );
                    }
                  
                    dbContext.SaveChanges();
                    this.Close();
                }
            }
        }
    }
}
