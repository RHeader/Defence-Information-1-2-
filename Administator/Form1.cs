﻿using System;
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
            string login = LoginText.Text;
            string password= PasswordText.Text;
          Logined = new Account(password,login);
            Logined.Login();
        }
    }
}
