
using System;

namespace Proyecto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Cuerpo = new System.Windows.Forms.Panel();
            this.Main = new System.Windows.Forms.Panel();
            this.LogoLyout = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Settings = new FontAwesome.Sharp.IconButton();
            this.Selling = new FontAwesome.Sharp.IconButton();
            this.Marketing = new FontAwesome.Sharp.IconButton();
            this.Customers = new FontAwesome.Sharp.IconButton();
            this.Products = new FontAwesome.Sharp.IconButton();
            this.Orders = new FontAwesome.Sharp.IconButton();
            this.Dashboard = new FontAwesome.Sharp.IconButton();
            this.Nav = new System.Windows.Forms.Panel();
            this.barraHome = new System.Windows.Forms.Panel();
            this.Home2 = new System.Windows.Forms.Label();
            this.Home = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Main.SuspendLayout();
            this.LogoLyout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.Nav.SuspendLayout();
            this.barraHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            this.SuspendLayout();
            // 
            // Cuerpo
            // 
            this.Cuerpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(19)))));
            this.Cuerpo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Cuerpo.Location = new System.Drawing.Point(206, 76);
            this.Cuerpo.Name = "Cuerpo";
            this.Cuerpo.Size = new System.Drawing.Size(1220, 752);
            this.Cuerpo.TabIndex = 2;
            this.Cuerpo.Paint += new System.Windows.Forms.PaintEventHandler(this.Cuerpo_Paint);
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(19)))));
            this.Main.Controls.Add(this.LogoLyout);
            this.Main.Controls.Add(this.Settings);
            this.Main.Controls.Add(this.Selling);
            this.Main.Controls.Add(this.Marketing);
            this.Main.Controls.Add(this.Customers);
            this.Main.Controls.Add(this.Products);
            this.Main.Controls.Add(this.Orders);
            this.Main.Controls.Add(this.Dashboard);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(206, 828);
            this.Main.TabIndex = 0;
            // 
            // LogoLyout
            // 
            this.LogoLyout.Controls.Add(this.Logo);
            this.LogoLyout.Location = new System.Drawing.Point(0, 0);
            this.LogoLyout.Name = "LogoLyout";
            this.LogoLyout.Size = new System.Drawing.Size(206, 176);
            this.LogoLyout.TabIndex = 12;
            // 
            // Logo
            // 
            this.Logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(25, 20);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(149, 139);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click_1);
            // 
            // Settings
            // 
            this.Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Settings.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.Settings.IconColor = System.Drawing.Color.Gainsboro;
            this.Settings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Settings.IconSize = 32;
            this.Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.Location = new System.Drawing.Point(3, 608);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.Settings.Size = new System.Drawing.Size(197, 65);
            this.Settings.TabIndex = 11;
            this.Settings.Text = "Setting";
            this.Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Selling
            // 
            this.Selling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Selling.FlatAppearance.BorderSize = 0;
            this.Selling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Selling.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Selling.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.Selling.IconColor = System.Drawing.Color.Gainsboro;
            this.Selling.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Selling.IconSize = 32;
            this.Selling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Selling.Location = new System.Drawing.Point(3, 395);
            this.Selling.Name = "Selling";
            this.Selling.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.Selling.Size = new System.Drawing.Size(197, 65);
            this.Selling.TabIndex = 9;
            this.Selling.Text = "Selling";
            this.Selling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Selling.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Selling.UseVisualStyleBackColor = true;
            this.Selling.Click += new System.EventHandler(this.Selling_Click);
            // 
            // Marketing
            // 
            this.Marketing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Marketing.FlatAppearance.BorderSize = 0;
            this.Marketing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Marketing.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Marketing.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.Marketing.IconColor = System.Drawing.Color.Gainsboro;
            this.Marketing.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Marketing.IconSize = 32;
            this.Marketing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Marketing.Location = new System.Drawing.Point(3, 537);
            this.Marketing.Name = "Marketing";
            this.Marketing.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.Marketing.Size = new System.Drawing.Size(197, 65);
            this.Marketing.TabIndex = 8;
            this.Marketing.Text = "Marketing";
            this.Marketing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Marketing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Marketing.UseVisualStyleBackColor = true;
            this.Marketing.Click += new System.EventHandler(this.Marketing_Click);
            // 
            // Customers
            // 
            this.Customers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Customers.FlatAppearance.BorderSize = 0;
            this.Customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customers.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Customers.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.Customers.IconColor = System.Drawing.Color.Gainsboro;
            this.Customers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Customers.IconSize = 32;
            this.Customers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Customers.Location = new System.Drawing.Point(3, 466);
            this.Customers.Name = "Customers";
            this.Customers.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.Customers.Size = new System.Drawing.Size(197, 65);
            this.Customers.TabIndex = 7;
            this.Customers.Text = "Customers";
            this.Customers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Customers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Customers.UseVisualStyleBackColor = true;
            this.Customers.Click += new System.EventHandler(this.Customers_Click);
            // 
            // Products
            // 
            this.Products.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Products.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Products.FlatAppearance.BorderSize = 0;
            this.Products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Products.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Products.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.Products.IconColor = System.Drawing.Color.Gainsboro;
            this.Products.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Products.IconSize = 32;
            this.Products.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Products.Location = new System.Drawing.Point(3, 324);
            this.Products.Name = "Products";
            this.Products.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.Products.Size = new System.Drawing.Size(197, 65);
            this.Products.TabIndex = 6;
            this.Products.Text = "Products";
            this.Products.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Products.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Products.UseVisualStyleBackColor = true;
            this.Products.Click += new System.EventHandler(this.Products_Click);
            // 
            // Orders
            // 
            this.Orders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(19)))));
            this.Orders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Orders.FlatAppearance.BorderSize = 0;
            this.Orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Orders.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Orders.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.Orders.IconColor = System.Drawing.Color.Gainsboro;
            this.Orders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Orders.IconSize = 32;
            this.Orders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Orders.Location = new System.Drawing.Point(3, 253);
            this.Orders.Name = "Orders";
            this.Orders.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.Orders.Size = new System.Drawing.Size(197, 65);
            this.Orders.TabIndex = 5;
            this.Orders.Text = "Orders";
            this.Orders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Orders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Orders.UseVisualStyleBackColor = false;
            this.Orders.Click += new System.EventHandler(this.Orders_Click);
            // 
            // Dashboard
            // 
            this.Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dashboard.FlatAppearance.BorderSize = 0;
            this.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Dashboard.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.Dashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.Dashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Dashboard.IconSize = 32;
            this.Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.Location = new System.Drawing.Point(3, 182);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.Dashboard.Size = new System.Drawing.Size(197, 65);
            this.Dashboard.TabIndex = 4;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Dashboard.UseVisualStyleBackColor = true;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // Nav
            // 
            this.Nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(19)))));
            this.Nav.Controls.Add(this.Main);
            this.Nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.Nav.Location = new System.Drawing.Point(0, 0);
            this.Nav.Name = "Nav";
            this.Nav.Size = new System.Drawing.Size(206, 828);
            this.Nav.TabIndex = 0;
            // 
            // barraHome
            // 
            this.barraHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.barraHome.Controls.Add(this.Home2);
            this.barraHome.Controls.Add(this.Home);
            this.barraHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraHome.Location = new System.Drawing.Point(206, 0);
            this.barraHome.Name = "barraHome";
            this.barraHome.Size = new System.Drawing.Size(1220, 55);
            this.barraHome.TabIndex = 0;
            // 
            // Home2
            // 
            this.Home2.AutoSize = true;
            this.Home2.Location = new System.Drawing.Point(69, 20);
            this.Home2.Name = "Home2";
            this.Home2.Size = new System.Drawing.Size(40, 15);
            this.Home2.TabIndex = 1;
            this.Home2.Text = "Home";
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.Home.ForeColor = System.Drawing.Color.Gainsboro;
            this.Home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.Home.IconColor = System.Drawing.Color.Gainsboro;
            this.Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Home.Location = new System.Drawing.Point(31, 12);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(32, 32);
            this.Home.TabIndex = 0;
            this.Home.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(206, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1220, 21);
            this.panel2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 828);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Cuerpo);
            this.Controls.Add(this.barraHome);
            this.Controls.Add(this.Nav);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Main.ResumeLayout(false);
            this.LogoLyout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.Nav.ResumeLayout(false);
            this.barraHome.ResumeLayout(false);
            this.barraHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).EndInit();
            this.ResumeLayout(false);

        }

       

        #endregion
        private System.Windows.Forms.Panel Cuerpo;
        private System.Windows.Forms.Panel Main;
        private FontAwesome.Sharp.IconButton Selling;
        private FontAwesome.Sharp.IconButton Marketing;
        private FontAwesome.Sharp.IconButton Customers;
        private FontAwesome.Sharp.IconButton Products;
        private FontAwesome.Sharp.IconButton Orders;
        private FontAwesome.Sharp.IconButton Dashboard;
        private System.Windows.Forms.Panel Nav;
        private FontAwesome.Sharp.IconButton Settings;
        private System.Windows.Forms.Panel barraHome;
        private FontAwesome.Sharp.IconPictureBox Home;
        private System.Windows.Forms.Label Home2;
        private System.Windows.Forms.Panel LogoLyout;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panel2;
    }
}

