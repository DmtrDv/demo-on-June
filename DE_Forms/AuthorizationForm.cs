using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DE_Lib;

namespace DE_Forms
{
    public partial class AuthorizationForm: Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            string userInputLogin = login_textBox.Text;
            string userInputPassword = password_textBox.Text;
            if (string.IsNullOrEmpty(userInputLogin)|| string.IsNullOrEmpty(userInputPassword))
            {
                MessageBox.Show("Введите логин или пароль");
                return;
            }
            User user = Database.Authorization(userInputLogin, userInputPassword);
            if (user != null)
            {
                WindowWatchingForm windowWatchingForm = new WindowWatchingForm(user, this);
                windowWatchingForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
        
        private void guest_button_Click(object sender, EventArgs e)
        {
            User user = new User() { role = "Гость", fio = "", login = "", password = "" };
            WindowWatchingForm windowWatchingForm = new WindowWatchingForm(user, this);
            windowWatchingForm.Show();
            this.Hide();
        }
    }
}
