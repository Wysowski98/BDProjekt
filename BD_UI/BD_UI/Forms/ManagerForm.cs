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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
            customizeDesign();
            this.TransparencyKey = Color.Empty;
        }

        private void customizeDesign()
        {
            subMenuRecordsDB.Visible = false;
            subMenuWorkers.Visible = false;
            subMenuShowroom.Visible = false;
            subMenuSell.Visible = false;
        }

        private void hideSubMenu()
        {
            if (subMenuRecordsDB.Visible == true) subMenuRecordsDB.Visible = false;
            if (subMenuWorkers.Visible == true) subMenuWorkers.Visible = false;
            if (subMenuShowroom.Visible == true) subMenuShowroom.Visible = false;
            if (subMenuSell.Visible == true) subMenuSell.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
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

        private void buttonRecordsDB_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuRecordsDB);
        }

        private void buttonWorkers_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuWorkers);
        }

        private void labelLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            openChildForm(new AddModelBrandForm());
            hideSubMenu();
        }

        private void buttonEditRecord_Click(object sender, EventArgs e)
        {
            openChildForm(new EditModelBrandForm());
            hideSubMenu();
        }

        private void buttonShowRecord_Click(object sender, EventArgs e)
        {
            openChildForm(new ShowModelBrandForm());
            hideSubMenu();
        }

        private void buttonAddWorker_Click(object sender, EventArgs e)
        {
            openChildForm(new AddWorkerForm());
            hideSubMenu();
        }

        private void buttonEditWorker_Click(object sender, EventArgs e)
        {
            openChildForm(new EditWorkerForm());
            hideSubMenu();
        }

        private void buttonShowWorker_Click(object sender, EventArgs e)
        {
            openChildForm(new ShowWorkerForm());
            hideSubMenu();
        }

        private void buttonShowroom_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuShowroom);
        }

        private void buttonAddShowroom_Click(object sender, EventArgs e)
        {
            openChildForm(new AddShowroomForm());
            hideSubMenu();
        }

        private void buttonEditShowroom_Click(object sender, EventArgs e)
        {
            openChildForm(new EditShowroomForm());
            hideSubMenu();
        }

        private void buttonShowShowroom_Click(object sender, EventArgs e)
        {
            openChildForm(new ShowShowroomForm());
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
    }
}
