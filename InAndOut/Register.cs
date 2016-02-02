using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InAndOut
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            this.ActiveControl = user_txtBox;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_Button_Click(object sender, EventArgs e)
        {
            string user = user_txtBox.Text;
            DataAccess dAccess = new DataAccess();

            string command = "Update Users set password = HASHBYTES('sha2_256', @password)";
            command += " where userName = @userName";

            dAccess.RegisterUser(command, user, pass_txtBox.Text);

            this.Close();            
        }
    }
}
