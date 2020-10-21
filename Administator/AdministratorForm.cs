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
        public AdministratorForm(bool Admin,string FName,string LName,bool BAccount,bool BPassword)
        {
            Administrator = Admin;
            FirstName = FName;
            LastName = LName;
            BlockedAccount = BAccount;
            BlockRangePassword = BPassword;

            InitializeComponent();
        }

        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            label1.Text = FirstName;
            label2.Text = LastName;
            if (Administrator == true)
            {
                ShowData.Enabled = true;
                ShowData.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Log
        }
    }
}
