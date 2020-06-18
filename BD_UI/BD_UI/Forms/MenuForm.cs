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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            customizeDesign();
            this.TransparencyKey = Color.Empty;
        }

        private void customizeDesign()
        {
            subMenuCustomers.Visible = false;
            subMenuOrders.Visible = false;
            subMenuProducts.Visible = false;
            subMenuSell.Visible = false;
        }

        private void hideSubMenu()
        {
            if (subMenuProducts.Visible == true) subMenuProducts.Visible = false;
            if (subMenuOrders.Visible == true) subMenuOrders.Visible = false;
            if (subMenuCustomers.Visible == true) subMenuCustomers.Visible = false;
            if (subMenuSell.Visible == true) subMenuSell.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            } else
            {
                subMenu.Visible = false;
            }
        }

        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            openChildForm(new AddCarForm());
            hideSubMenu();
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuProducts);
        }

        private void buttonEditCar_Click(object sender, EventArgs e)
        {
            openChildForm(new EditCarForm());
            hideSubMenu();
        }

        private void buttonShowCar_Click(object sender, EventArgs e)
        {
            openChildForm(new ShowCarForm());
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuOrders);
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            //
            openChildForm(new AddOrderForm());
            hideSubMenu();
        }

        private void buttonEditOrder_Click(object sender, EventArgs e)
        {
            openChildForm(new EditOrderForm());
            hideSubMenu();
        }

        private void buttonShowOrder_Click(object sender, EventArgs e)
        {
            openChildForm(new ShowOrderForm());
            hideSubMenu();
        }

        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuCustomers);
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new AddCustomerForm());
            hideSubMenu();
        }

        private void buttonEditCustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new EditCustomerForm());
            hideSubMenu();
        }

        private void buttonShowCustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new ShowCustomerForm());
            hideSubMenu();
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuSell);
        }

        private void buttonSalesHistory_Click(object sender, EventArgs e)
        {
            openChildForm(new SalesHistoryForm());
            hideSubMenu();
        }

        private void buttonRank_Click(object sender, EventArgs e)
        {
            openChildForm(new SalesRankForm());
            hideSubMenu();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            openChildForm(new HelpForm()); 
        }

        private void labelLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

    }
}
