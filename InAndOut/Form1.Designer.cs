﻿namespace InAndOut
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currentTime = new System.Windows.Forms.TextBox();
            this.in_button = new System.Windows.Forms.Button();
            this.out_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarReporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.armarInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verReportesMensualesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actual_user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.override_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentTime
            // 
            this.currentTime.BackColor = System.Drawing.Color.White;
            this.currentTime.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTime.ForeColor = System.Drawing.Color.Green;
            this.currentTime.Location = new System.Drawing.Point(24, 65);
            this.currentTime.MaximumSize = new System.Drawing.Size(283, 40);
            this.currentTime.MinimumSize = new System.Drawing.Size(283, 40);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(283, 29);
            this.currentTime.TabIndex = 0;
            // 
            // in_button
            // 
            this.in_button.BackColor = System.Drawing.Color.Transparent;
            this.in_button.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_button.ForeColor = System.Drawing.Color.Green;
            this.in_button.Location = new System.Drawing.Point(24, 111);
            this.in_button.Name = "in_button";
            this.in_button.Size = new System.Drawing.Size(140, 36);
            this.in_button.TabIndex = 1;
            this.in_button.Text = "Ingreso";
            this.in_button.UseVisualStyleBackColor = false;
            this.in_button.Click += new System.EventHandler(this.in_button_click);
            // 
            // out_button
            // 
            this.out_button.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_button.ForeColor = System.Drawing.Color.Red;
            this.out_button.Location = new System.Drawing.Point(167, 111);
            this.out_button.Name = "out_button";
            this.out_button.Size = new System.Drawing.Size(140, 36);
            this.out_button.TabIndex = 2;
            this.out_button.Text = "Egreso";
            this.out_button.UseVisualStyleBackColor = true;
            this.out_button.Click += new System.EventHandler(this.out_button_click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(24, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(283, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "SALIR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.registrarToolStripMenuItem,
            this.herramientasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(369, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.loginToolStripMenuItem.Text = "Logout";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.registrarToolStripMenuItem.Text = "Crear Clave";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarReporteToolStripMenuItem,
            this.armarInfoToolStripMenuItem,
            this.verReportesMensualesToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // generarReporteToolStripMenuItem
            // 
            this.generarReporteToolStripMenuItem.Name = "generarReporteToolStripMenuItem";
            this.generarReporteToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.generarReporteToolStripMenuItem.Text = "Generar Reporte...";
            this.generarReporteToolStripMenuItem.Click += new System.EventHandler(this.generarReporteToolStripMenuItem_Click);
            // 
            // armarInfoToolStripMenuItem
            // 
            this.armarInfoToolStripMenuItem.Name = "armarInfoToolStripMenuItem";
            this.armarInfoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.armarInfoToolStripMenuItem.Text = "Recopilar Reportes...";
            this.armarInfoToolStripMenuItem.Click += new System.EventHandler(this.armarInfoToolStripMenuItem_Click);
            // 
            // verReportesMensualesToolStripMenuItem
            // 
            this.verReportesMensualesToolStripMenuItem.Name = "verReportesMensualesToolStripMenuItem";
            this.verReportesMensualesToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.verReportesMensualesToolStripMenuItem.Text = "Ver Reportes Mensuales...";
            this.verReportesMensualesToolStripMenuItem.Click += new System.EventHandler(this.verReportesMensualesToolStripMenuItem_Click);
            // 
            // actual_user
            // 
            this.actual_user.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actual_user.Location = new System.Drawing.Point(138, 34);
            this.actual_user.Name = "actual_user";
            this.actual_user.ReadOnly = true;
            this.actual_user.Size = new System.Drawing.Size(169, 25);
            this.actual_user.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuario Actual :";
            // 
            // override_btn
            // 
            this.override_btn.Location = new System.Drawing.Point(314, 70);
            this.override_btn.Name = "override_btn";
            this.override_btn.Size = new System.Drawing.Size(43, 23);
            this.override_btn.TabIndex = 8;
            this.override_btn.Text = "OR";
            this.override_btn.UseVisualStyleBackColor = true;
            this.override_btn.Click += new System.EventHandler(this.override_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 212);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.override_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.actual_user);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.out_button);
            this.Controls.Add(this.in_button);
            this.Controls.Add(this.currentTime);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(385, 250);
            this.MinimumSize = new System.Drawing.Size(385, 250);
            this.Name = "Form1";
            this.Text = "In and Out";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox currentTime;
        private System.Windows.Forms.Button in_button;
        private System.Windows.Forms.Button out_button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.TextBox actual_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem generarReporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem armarInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verReportesMensualesToolStripMenuItem;
        private System.Windows.Forms.Button override_btn;
        private System.Windows.Forms.Button button1;
    }
}

