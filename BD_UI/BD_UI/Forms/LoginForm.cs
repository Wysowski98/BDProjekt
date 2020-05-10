using BD_UI.Database;
using BD_UI.Database.Domain;
using System;
using System.Windows.Forms;

namespace BD_UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
   
        private void buttonLogin_Click(object sender, EventArgs e)
        {        
            if (textBoxUsername.Text == "pracownik" && textBoxPassword.Text == "pracownik")
            {
                this.Hide();
                MenuForm menuForm = new MenuForm();
                menuForm.ShowDialog();
            }
            else if (textBoxUsername.Text == "kierownik" && textBoxPassword.Text == "kierownik")
            {
                this.Hide();
                ManagerForm managerForm = new ManagerForm();
                managerForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nieprawidłowy login lub hasło. Proszę spróbować ponownie.", "Logowanie nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
