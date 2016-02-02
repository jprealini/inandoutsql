﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InAndOut
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.ActiveControl = user_txtBox;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ok_Button_Click(object sender, EventArgs e)
        {
            DataAccess dAccess = new DataAccess();
            var result = dAccess.GetUser("select * from Users where UserName = @userName and Password = HASHBYTES('sha2_256', @password)", user_txtBox.Text, pass_txtBox.Text);
            if (!result)
            {
                ClearTextBoxes();
                MessageBox.Show("Usuario o contraseña incorrectos... vuelva a intentar");
            }
            else            
                this.Close();
        }

        private void ClearTextBoxes()
        {
            user_txtBox.Clear();
            pass_txtBox.Clear();
        }
    }
}
