﻿using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Web;
using System.Globalization;

namespace InAndOut
{
    public partial class Form1 : Form
    {
        Timer tmr = null;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login form = new Login();
            form.ShowDialog();
            actual_user.Text = Global.appUser;
            GetStatus();            
            currentTime.TextAlign = HorizontalAlignment.Center;            
            StartTimer();
        }

        private void GetStatus()
        {
            var lastActivity = GetLastActivity();
            
            switch(lastActivity)
            {
                case 1:
                    in_button.Enabled = false;
                    out_button.Enabled = true;
                    currentTime.ForeColor = Color.Red;
                    break;
                case 2:
                    in_button.Enabled = true;
                    out_button.Enabled = false;
                    currentTime.ForeColor = Color.Green;
                    break;
                case 0:
                    in_button.Enabled = true;
                    out_button.Enabled = false;
                    currentTime.ForeColor = Color.Green;
                    break;
            }            
        }

        private int GetLastActivity()
        {
            DataAccess dAccess = new DataAccess();
            var result = dAccess.ReadLastActivity("select top 1 actionId from activity where userId = " + Global.appUserId + " order by id desc");  
            return result;        
        }

        private void in_button_click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirma que desea registrar el ingreso?", "Confirmacion de Ingreso", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataAccess dAccess = new DataAccess();

                string command = "INSERT INTO Activity (userId, fecha, hora, actionId)";
                command += " VALUES (@userId, @fecha, @hora, @actionId)";

                dAccess.SaveAction(command, Global.appUserId, Enums.Actions.IN, currentTime.Text);

                GetStatus();
            }
            else if (dialogResult == DialogResult.No)
            {
                GetStatus();
            }
            
        }

        private void out_button_click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirma que desea registrar el egreso?", "Confirmacion de Egreso", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataAccess dAccess = new DataAccess();

                string command = "INSERT INTO Activity (userId, fecha, hora, actionId)";
                command += " VALUES (@userId, @fecha, @hora, @actionId)";

                dAccess.SaveAction(command, Global.appUserId, Enums.Actions.OUT, currentTime.Text);

                GetStatus();
            }
            else if (dialogResult == DialogResult.No)
            {
                GetStatus();
            }
            
        }

        private void StartTimer()
        {
            tmr = new System.Windows.Forms.Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Enabled = true;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            currentTime.Text = DateTime.Now.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.appUser = "";
            actual_user.Text = "";
            Login form = new Login();
            form.ShowDialog();
            actual_user.Text = Global.appUser;
            loginToolStripMenuItem.Text = "Logout";
            GetStatus();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.appUser = "";
            actual_user.Text = ""; 
            Register form = new Register();
            form.ShowDialog();            
            loginToolStripMenuItem.Text = "Login";
            in_button.Enabled = false;
            out_button.Enabled = false;
        }

        private void generarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report form = new Report();
            form.ShowDialog();
        }

        private void armarInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrepareReport form = new PrepareReport();
            form.ShowDialog();
        }

        private void verReportesMensualesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonthlyReports form = new MonthlyReports();
            form.ShowDialog();
        }

        private void override_btn_Click(object sender, EventArgs e)
        {
            DateAndTimeOverride form = new DateAndTimeOverride();
            form.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess data = new DataAccess();
            var result = data.connectMySql();
            MessageBox.Show(result.ToString());
        }         
    }
}
