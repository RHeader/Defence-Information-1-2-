using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administator
{
   
    public partial class Authorization : Form
    {
    public  static  int CrashHandlerPassword=0;
      Account Logined;
        Form AuthorizationForm;
        public Authorization()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AuthorizationForm = new Auth();
            AuthorizationForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CrashHandlerPassword == 3)
            {
                Application.Exit();
            }
            string login = LoginText.Text;
            string password= PasswordText.Text;
            if (password.Length >= 8)
            {
                Logined = new Account(password, login);
                Logined.Login();
            }
            else
            {
                MessageBox.Show("Введеный пароль слишком короткий, минимальная длина 8 символов");
            }
            CrashHandlerPassword++;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("8 Вариант .Наличие латинских букв и символов кириллицы.  Никифоров Антон");
        }
    }
}
