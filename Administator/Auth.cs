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
    public partial class Auth : Form
    {
        DataController Data;
        public Auth()
        {
            InitializeComponent();
        }

        private void Auth_Load(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Data = new DataController();
           
            if (!string.IsNullOrEmpty(PasswordReg.Text))
            { if (PasswordReg.Text == RepeatPassword.Text)
                {   string Password = PasswordReg.Text;
                    string Login = LoginReg.Text;
                    string FirstName = FirstNameReg.Text;
                    string LastName = LastNameReg.Text;
                    Data.SaveData(Login, Password, FirstName, LastName);
                    MessageBox.Show("Регистрация успешна", "!!!", MessageBoxButtons.OK,
       MessageBoxIcon.Information);
                    this.Close();
               
                    
                }
                else
                {
                    MessageBox.Show(
       "Пароли не совпадают",
       "Ошибка",
       MessageBoxButtons.OK,
       MessageBoxIcon.Information,
       MessageBoxDefaultButton.Button1,
       MessageBoxOptions.DefaultDesktopOnly);
                    PasswordReg.Clear();
                    RepeatPassword.Clear();
                }
            }
         else
            {
                MessageBox.Show(
        "Вы не ввели пароль",
        "Ошибка",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
            }
            
           

          
        }
    }
}
