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
    public partial class SalesRankForm : Form
    {
        private DatabaseContext databaseContext;

        public SalesRankForm()
        {
            DesignTimeDbContextFactory factory = new DesignTimeDbContextFactory();
            databaseContext = factory.CreateDbContext();
            InitializeComponent();
            var orders = databaseContext.Set<Orders>().Include(o => o.Car).ThenInclude(c => c.CarShowroom);
            var carshowrooms = databaseContext.Set<CarShowrooms>();
            int max = 0;
            var maxId = 0;

            foreach (CarShowrooms cs in carshowrooms)
            {
                int temp = 0;
                foreach (Orders order in orders)
                {
                    if(cs.Id == order.Car.CarShowroom.Id)
                    {
                        if(order.RealizationDate < DateTime.Now)
                            temp++;
                    }
                }
                if (temp > max)
                {
                    max = temp;
                    maxId = cs.Id;
                }
            }
            textBoxBestShowroom.Text = carshowrooms.First(cs => cs.Id == maxId).Name +  ", " + carshowrooms.First(cs => cs.Id == maxId).Address;
            textBoxNumberOfCarsBest.Text = max.ToString();

            foreach (CarShowrooms cs in carshowrooms)
            {
                comboBoxOtherShowroom.Items.Add(cs.Address);
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

        private void comboBoxOtherShowroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOtherShowroom.SelectedIndex > -1)
            {
                var orders = databaseContext.Set<Orders>().Include(o => o.Car).ThenInclude(c => c.CarShowroom);
                int temp = 0;
                foreach (Orders order in orders)
                {
                    if (order.Car.CarShowroom.Address == comboBoxOtherShowroom.SelectedItem.ToString())
                    {
                        if (order.RealizationDate < DateTime.Now)
                            temp++;
                    }
                }
                textBoxNumberOfCarsOther.Text = temp.ToString();
            }
        }
    }
}
