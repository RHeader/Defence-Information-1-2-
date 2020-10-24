using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Administator
{
 public class Account
    {
     string password;
     string login;
        int id;
        bool Administrator;
        string FirstName;
        string LastName;
        bool BlockedAccount;
        bool BlockedPassword;
        DataController AccountInfo = new DataController();
        public Account(string password,string login){
            this.password = password;
            this.login = login;
            }   
      
      public  void Login()  
        { 
           
            if (AccountInfo.Login(password, login, out id, out Administrator,out FirstName,out LastName, out BlockedAccount ,out BlockedPassword))
            {
                    Form WindowAccount = new AdministratorForm(Administrator,FirstName,LastName,BlockedAccount,BlockedPassword,this);
                    WindowAccount.Show();
                Authorization.CrashHandlerPassword = 0;
            }
          
       
        }
        public void ChangePassword(string OldPass,string NewPass)
        {
          
            if (OldPass == password)
            {
                if (BlockedPassword)
                {
                    if (StringIsValid(NewPass))
                    {
                        AccountInfo.UpdatePassword(id, NewPass);
                        MessageBox.Show("Пароль успешно изменен", "Аутенфикация", MessageBoxButtons.OK,
        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Аккаунт защищен от смены пароля, используйте только Латинские и символы Кириллицы", "Повторите ввод", MessageBoxButtons.OK,
         MessageBoxIcon.Information);
                    }
                }
                else
                {
                    AccountInfo.UpdatePassword(id, NewPass);
                    MessageBox.Show("Пароль успешно изменен", "Аутенфикация", MessageBoxButtons.OK,
         MessageBoxIcon.Information);
                }
             
            }
            else
            {
                MessageBox.Show("Старый пароль введен неверно", "Предупреждение", MessageBoxButtons.OK,
MessageBoxIcon.Information);
            }
           


        }
        public static bool StringIsValid(string str) // задание 8 вариант 
        {
            return !string.IsNullOrEmpty(str) && Regex.IsMatch(str, @"^[A-Za-zА-ЯЁа-яё]+$") ;
        }
    }
       

    }
    /* •	просмотр списка имен зарегистрированных пользователей и установленных для них параметров 
     * (блокировка учетной записи, включение ограничений на выбираемые пароли)
     * – всего списка целиком в одном окне или по одному элементу списка с возможностью перемещения к его началу или концу;
•	добавление уникального имени нового пользователя к списку с пустым паролем (строкой нулевой длины);
•	блокирование возможности работы пользователя с заданным именем;
•	включение или отключение ограничений на выбираемые пользователем пароли (в соответствии с индивидуальным заданием, определяемым номером варианта);
•	завершение работы с программой.
*/



