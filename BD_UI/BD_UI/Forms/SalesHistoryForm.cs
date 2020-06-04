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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace BD_UI
{
    public partial class SalesHistoryForm : Form
    {
        private DatabaseContext databaseContext;

        public SalesHistoryForm()
        {
            DesignTimeDbContextFactory factory = new DesignTimeDbContextFactory();
            databaseContext = factory.CreateDbContext();
            InitializeComponent();
            FillListBoxes();
        }

        private void FillListBoxes()
        {
            listBoxCurrentOrders.Items.Clear();
            listBoxCompletedOrders.Items.Clear();

            var orders = databaseContext.Set<Orders>().Include(o => o.Car).Include(o => o.Client);
            foreach(Orders order in orders)
            {
                var car = databaseContext.Cars.Include(c => c.Model).First(c => c == order.Car);
                var model = databaseContext.Models.Include(m => m.Brand).First(m => m == car.Model);
                var brand = databaseContext.CarBrands.First(b => b == model.Brand);
                var client = databaseContext.Clients.First(c => c == order.Client);
                if (order.RealizationDate < DateTime.Now)
                {
                    listBoxCompletedOrders.Items.Add(
                        order.Id.ToString() + ". " + brand.Name + " " + model.Name + ", " + car.ProductionYear + ", " + car.Body + " - " + client.LastName + ", " + client.FirstName);
                }
                else
                {
                    listBoxCurrentOrders.Items.Add(
                        order.Id.ToString() + ". " + brand.Name + " " + model.Name + ", " + car.ProductionYear + ", " + car.Body + " - " + client.LastName + ", " + client.FirstName);
                }
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

        private void buttonReport_Click(object sender, EventArgs e)
        {
            using (System.IO.MemoryStream memoryStream = new System.IO.MemoryStream())
            {
                Document document = new Document(PageSize.A4, 10, 10, 10, 10);

                PdfWriter writer = PdfWriter.GetInstance(document, memoryStream);
                document.Open();

                // Pending orders header - para1
                Paragraph para1 = new Paragraph("Zamówienia w trakcie realizacji:");
                para1.Font = FontFactory.GetFont(FontFactory.TIMES_BOLD, 12f, BaseColor.BLACK);
                document.Add(para1);

                // Pending orders list - para2
                Paragraph para2 = new Paragraph();
                para2.Font = FontFactory.GetFont(FontFactory.TIMES, 9f, BaseColor.BLACK);
                
                foreach (object order in listBoxCurrentOrders.Items)
                {
                    para2.Add(order.ToString() + "\n");
                }
                document.Add(para2);

                // Pending orders sum - para3
                Paragraph para3 = new Paragraph();
                para3.Font = FontFactory.GetFont(FontFactory.TIMES_BOLD, 9f, BaseColor.BLACK);
                para3.SpacingBefore = 5;
                para3.SpacingAfter = 10;
                int pendingSum = listBoxCurrentOrders.Items.Count;
                para3.Add("Suma zamówien w trakcie realizacji: " + pendingSum.ToString());
                document.Add(para3);
                
                // Completed orders header - para4
                Paragraph para4 = new Paragraph("Zamówienia zrealizowane:");
                para4.Font = FontFactory.GetFont(FontFactory.TIMES_BOLD, 12f, BaseColor.BLACK);
                document.Add(para4);

                // Completed orders list - para5
                Paragraph para5 = new Paragraph();
                para5.Font = FontFactory.GetFont(FontFactory.TIMES, 9f, BaseColor.BLACK);

                foreach (object order in listBoxCompletedOrders.Items)
                {
                    para5.Add(order.ToString() + "\n");
                }
                document.Add(para5);

                // Completed orders sum - para6
                Paragraph para6 = new Paragraph();
                para6.Font = FontFactory.GetFont(FontFactory.TIMES_BOLD, 9f, BaseColor.BLACK);
                para6.SpacingBefore = 5;
                para6.SpacingAfter = 10;
                int completedSum = listBoxCompletedOrders.Items.Count;
                para6.Add("Suma zrealizowanych zamówien: " + completedSum.ToString());
                document.Add(para6);

                // Orders count in each showroom
                var orders = databaseContext.Set<Orders>().Include(o => o.Car);
                var showrooms = databaseContext.Set<CarShowrooms>().Include(cs => cs.Cars);

                Paragraph para = new Paragraph();
                foreach(CarShowrooms showroom in showrooms)
                {
                    int countSum = 0;
                    int countComplete = 0;
                    int countPrices = 0;
                    foreach(Orders order in orders)
                    {
                        if (showroom.Cars.Contains(order.Car))
                        {
                            countSum++;
                            countPrices += order.Price;
                            if (order.RealizationDate < DateTime.Now)
                                countComplete++;
                        }
                    }
                    para.Clear();
                    para.Font = FontFactory.GetFont(FontFactory.TIMES_BOLD, 9f, BaseColor.BLACK);
                    para.SpacingBefore = 5;
                    para.SpacingAfter = 5;
                    para.Add(showroom.Name + ", " + showroom.Address + "\n");
                    para.Font = FontFactory.GetFont(FontFactory.TIMES, 9f, BaseColor.BLACK);
                    para.Add("Zrealizowanych zamówien: " + countComplete.ToString() + "\n");
                    para.Add("Zamówien w sumie: " + countSum.ToString() + "\n");
                    para.Add("Kwota sumaryczna zamówien: " + countPrices.ToString() + "\n");
                    document.Add(para);
                }

                document.Close();
                byte[] bytes = memoryStream.ToArray();
                memoryStream.Close();

                // Save PDF to file in device memory
                string fileName = "Sales_Report.pdf";
                using (FileStream fs = File.Create(fileName))
                {
                    fs.Write(bytes, 0, (int)bytes.Length);
                }

                MessageBox.Show("Pomyślnie wygenerowano raport do pliku " + fileName);
            }
        }
    }
}
