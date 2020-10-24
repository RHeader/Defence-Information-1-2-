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
    public partial class AdministratorForm : Form
    {
        bool Administrator;
        string FirstName;
        string LastName;
        bool BlockedAccount;
        bool BlockRangePassword;
        DataController Data = new DataController();
        Account Logined;
        public AdministratorForm(bool Admin, string FName, string LName, bool BAccount, bool BPassword,Account Logined)
        {
            Administrator = Admin;
            FirstName = FName;
            LastName = LName;
            BlockedAccount = BAccount;
            BlockRangePassword = BPassword;
            this.Logined = Logined;
            InitializeComponent();
            
        }
        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            label1.Text = FirstName;
            label2.Text = LastName;
            if (Administrator == true)
            {
                label5.Text = "Режим Администратора";
                ShowData.Enabled = true;
                ShowData.Visible = true;
                Data.LoadInfoForAdmin(ref ShowData);               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string OldPassword = this.OldPassword.Text;
            string NewPassword = this.NewPassword.Text;
           
          Logined.ChangePassword(OldPassword,NewPassword);
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            if (Administrator == true) Data.UpdateInfo(ShowData);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
