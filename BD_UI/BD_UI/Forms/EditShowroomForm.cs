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
using Microsoft.EntityFrameworkCore;

namespace BD_UI
{
    public partial class EditShowroomForm : Form
    {
        private DatabaseContext dbContext;

        private bool checkEntries()
        {
            if ((!String.IsNullOrWhiteSpace(textBoxShowroomAdress.Text)))
            {
                if ((!String.IsNullOrWhiteSpace(textBoxShowroomName.Text)))
                {                
                        return true;
                }
            }
            return false;
        }

        public EditShowroomForm()
        {
            InitializeComponent();
            DesignTimeDbContextFactory factory = new DesignTimeDbContextFactory();
            dbContext = factory.CreateDbContext();
            listBoxShowrooms.Items.Clear();
            checkedListBoxCars.Items.Clear();
            checkedListBoxWorkers.Items.Clear();

            var showrooms = dbContext.Set<CarShowrooms>();
            foreach (CarShowrooms cs in showrooms)
            {
                listBoxShowrooms.Items.Add(cs.Address + ", " + cs.Name + ", ID: " + cs.Id);
            }
            var employees = dbContext.Set<Employees>().Include(e => e.CarShowroom);
            foreach (Employees employee in employees)
            {
                checkedListBoxWorkers.Items.Add(employee.LastName + ", " + employee.FirstName + ", ID: " + employee.Id);
            }
            var cars = dbContext.Set<Cars>().Include(c => c.CarShowroom).Include(c => c.Model);
            foreach (Cars car in cars)
            {
                checkedListBoxCars.Items.Add(car.Model.Name + ", " + car.ProductionYear + ", " + car.Body + ", ID: " + car.Id);
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (listBoxShowrooms.SelectedIndex > -1)
            {
                if (checkEntries())
                {
                    CarShowrooms sr = dbContext.Set<CarShowrooms>().FirstOrDefault(csr => csr.Id == Int32.Parse(listBoxShowrooms.SelectedItem.ToString().Split(',')[2].Split(':')[1].Substring(1)));
                    sr.Name = textBoxShowroomName.Text;
                    sr.Address = textBoxShowroomAdress.Text;
                    for (int i = 0; i < checkedListBoxWorkers.Items.Count; i++)
                    {
                        Employees emp = dbContext.Set<Employees>().Include(em => em.CarShowroom).FirstOrDefault(em => em.Id == Int32.Parse(checkedListBoxWorkers.GetItemText(checkedListBoxWorkers.Items[i]).Split(',')[2].Split(':')[1].Substring(1)));
                        if(checkedListBoxWorkers.GetItemCheckState(i) == CheckState.Checked)
                        {
                            emp.CarShowroom = sr;
                        }
                        else
                        {
                            if (checkedListBoxWorkers.GetItemCheckState(i) == CheckState.Unchecked)
                            {
                                if (emp.CarShowroom == sr)
                                    emp.CarShowroom = null;
                            }
                        }
                    }
                    for (int i = 0; i < checkedListBoxCars.Items.Count; i++)
                    {
                        Cars car = dbContext.Set<Cars>().Include(c => c.CarShowroom).FirstOrDefault(cr => cr.Id == Int32.Parse(checkedListBoxCars.GetItemText(checkedListBoxCars.Items[i]).Split(',')[3].Split(':')[1].Substring(1)));
                        if (checkedListBoxCars.GetItemCheckState(i) == CheckState.Checked)
                        {
                            car.CarShowroom = sr;
                        }
                        else
                        {
                            if (checkedListBoxCars.GetItemCheckState(i) == CheckState.Unchecked)
                            {
                                if (car.CarShowroom == sr)
                                    car.CarShowroom = null;
                            }
                        }
                    }
                    dbContext.SaveChanges();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nie wszystkie wymagane pola zostały uzupełnione!", "Błąd modyfikowania salonu.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Nie wybrano salonu do modyfikacji!", "Błąd modyfikowania salonu.", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxShowrooms.SelectedIndex > -1)
            {
                CarShowrooms sr = dbContext.Set<CarShowrooms>().FirstOrDefault(csr => csr.Id == Int32.Parse(listBoxShowrooms.SelectedItem.ToString().Split(',')[2].Split(':')[1].Substring(1)));
                dbContext.Set<CarShowrooms>().Remove(sr);
                dbContext.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nie wybrano salonu do usunięcia!", "Błąd usuwania salonu.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxShowrooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxCars.Items.Count; i++)
            {
                checkedListBoxWorkers.SetItemCheckState(checkedListBoxWorkers.Items.IndexOf(checkedListBoxWorkers.Items[i]), CheckState.Unchecked);
            }
            for (int i = 0; i < checkedListBoxCars.Items.Count; i++)
            {
                checkedListBoxCars.SetItemCheckState(checkedListBoxCars.Items.IndexOf(checkedListBoxCars.Items[i]), CheckState.Unchecked);
            }

            var showrooms = dbContext.Set<CarShowrooms>().Include(csr => csr.Employees).Include(csr => csr.Cars);

            CarShowrooms cs = showrooms.FirstOrDefault(csr => csr.Address == listBoxShowrooms.SelectedItem.ToString().Split(',')[0] && csr.Name == listBoxShowrooms.SelectedItem.ToString().Split(',')[1].Substring(1));
            textBoxShowroomAdress.Text = cs.Address;
            textBoxShowroomName.Text = cs.Name;

            for(int i = 0; i < checkedListBoxWorkers.Items.Count; i++)
            {
                Employees emp = cs.Employees.Find(em => em.Id == Int32.Parse(checkedListBoxWorkers.GetItemText(checkedListBoxWorkers.Items[i]).Split(',')[2].Split(':')[1].Substring(1)));
                if(emp != null)
                {
                    checkedListBoxWorkers.SetItemCheckState(checkedListBoxWorkers.Items.IndexOf(checkedListBoxWorkers.Items[i]), CheckState.Checked);
                }
                else
                    checkedListBoxWorkers.SetItemCheckState(checkedListBoxWorkers.Items.IndexOf(checkedListBoxWorkers.Items[i]), CheckState.Unchecked);
            }


                for (int i = 0; i < checkedListBoxCars.Items.Count; i++)
                {
                    Cars car = cs.Cars.Find(cr => cr.Id == Int32.Parse(checkedListBoxCars.GetItemText(checkedListBoxCars.Items[i]).Split(',')[3].Split(':')[1].Substring(1)));

                    if (car != null)
                    {
                        checkedListBoxCars.SetItemCheckState(checkedListBoxCars.Items.IndexOf(checkedListBoxCars.Items[i]), CheckState.Checked);
                    }
                    else
                        checkedListBoxCars.SetItemCheckState(checkedListBoxCars.Items.IndexOf(checkedListBoxCars.Items[i]), CheckState.Unchecked);
                }

        }
    }
}
