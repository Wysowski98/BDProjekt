using System;
using System.Windows.Forms;
using BD_UI.Database;
using BD_UI.Database.Domain;
using Microsoft.EntityFrameworkCore;

namespace BD_UI
{
    public partial class LoginForm : Form
    {
        private DatabaseContext dbContext;

        public LoginForm()
        {
            InitializeComponent();
            DesignTimeDbContextFactory fac = new DesignTimeDbContextFactory();
            dbContext = fac.CreateDbContext();
        }
   
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var accs = dbContext.Set<Accounts>().Include(a => a.Employee).ThenInclude(em => em.Job);
            foreach(Accounts acc in accs)
            {
                if(acc.Login == textBoxUsername.Text && acc.Password == textBoxPassword.Text)
                {
                    if(acc.Employee.Job.Id == 1)
                    {
                        this.Hide();
                        ManagerForm managerForm = new ManagerForm();
                        managerForm.ShowDialog();
                    }
                    else
                    {
                        this.Hide();
                        MenuForm menuForm = new MenuForm();
                        menuForm.ShowDialog();
                    }
                }               
            }
            if (this.Visible)
            {
                MessageBox.Show("Nieprawidłowy login lub hasło. Proszę spróbować ponownie.", "Logowanie nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBoxUsername.Clear();
            textBoxPassword.Clear();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                 buttonLogin_Click(this, new EventArgs());
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin_Click(this, new EventArgs());
            }

        }
    }
}
