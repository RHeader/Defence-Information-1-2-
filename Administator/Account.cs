using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administator
{
  class Account
    {
     string password;
     string login;
        int id;
        bool Administrator;
        string FirstName;
        string LastName;
        bool BlockedAccount;
        bool BlockedPassword;
   
        public Account(string password,string login){
            this.password = password;
            this.login = login;
            }   

       public void Login()  
        { 
            DataController AccountInfo = new DataController();
            if (AccountInfo.Login(password, login, out id, out Administrator,out FirstName,out LastName, out BlockedAccount ,out BlockedPassword))
            {
                    Form WindowAccount = new AdministratorForm(Administrator,FirstName,LastName,BlockedAccount,BlockedPassword);
                    WindowAccount.Show();       
            }
          
            
        }
      public void ChangePassword(string password)
        {

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



