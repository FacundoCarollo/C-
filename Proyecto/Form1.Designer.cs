
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Settings = new FontAwesome.Sharp.IconButton();
            this.Home = new FontAwesome.Sharp.IconButton();
            this.Selling = new FontAwesome.Sharp.IconButton();
            this.Marketing = new FontAwesome.Sharp.IconButton();
            this.Customers = new FontAwesome.Sharp.IconButton();
            this.Products = new FontAwesome.Sharp.IconButton();
            this.Orders = new FontAwesome.Sharp.IconButton();
            this.Dashboard = new FontAwesome.Sharp.IconButton();
            this.LogoLyout = new System.Windows.Forms.FlowLayoutPanel();
            this.Nav = new System.Windows.Forms.Panel();
            this.Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Nav.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cuerpo
            // 
            this.Cuerpo.Location = new System.Drawing.Point(206, 0);
            this.Cuerpo.Name = "Cuerpo";
            this.Cuerpo.Size = new System.Drawing.Size(1217, 828);
            this.Cuerpo.TabIndex = 2;
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(19)))));
            this.Main.Controls.Add(this.pictureBox1);
            this.Main.Controls.Add(this.Settings);
            this.Main.Controls.Add(this.Home);
            this.Main.Controls.Add(this.Selling);
            this.Main.Controls.Add(this.Marketing);
            this.Main.Controls.Add(this.Customers);
            this.Main.Controls.Add(this.Products);
            this.Main.Controls.Add(this.Orders);
            this.Main.Controls.Add(this.Dashboard);
            this.Main.Controls.Add(this.LogoLyout);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(206, 828);
            this.Main.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(19)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // Settings
            // 
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Settings.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.Settings.IconColor = System.Drawing.Color.Gainsboro;
            this.Settings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Settings.IconSize = 32;
            this.Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.Location = new System.Drawing.Point(-3, 679);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.Settings.Size = new System.Drawing.Size(200, 65);
            this.Settings.TabIndex = 11;
            this.Settings.Text = "Setting";
            this.Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.Home.IconColor = System.Drawing.Color.Gainsboro;
            this.Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Home.IconSize = 32;
            this.Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.Location = new System.Drawing.Point(3, 182);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.Home.Size = new System.Drawing.Size(197, 65);
            this.Home.TabIndex = 10;
            this.Home.Text = "Home";
            this.Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Selling
            // 
            this.Selling.FlatAppearance.BorderSize = 0;
            this.Selling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Selling.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Selling.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.Selling.IconColor = System.Drawing.Color.Gainsboro;
            this.Selling.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Selling.IconSize = 32;
            this.Selling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Selling.Location = new System.Drawing.Point(0, 466);
            this.Selling.Name = "Selling";
            this.Selling.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.Selling.Size = new System.Drawing.Size(200, 65);
            this.Selling.TabIndex = 9;
            this.Selling.Text = "Selling";
            this.Selling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Selling.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Selling.UseVisualStyleBackColor = true;
            this.Selling.Click += new System.EventHandler(this.Selling_Click);
            // 
            // Marketing
            // 
            this.Marketing.FlatAppearance.BorderSize = 0;
            this.Marketing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Marketing.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Marketing.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.Marketing.IconColor = System.Drawing.Color.Gainsboro;
            this.Marketing.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Marketing.IconSize = 32;
            this.Marketing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Marketing.Location = new System.Drawing.Point(3, 608);
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
            this.Customers.FlatAppearance.BorderSize = 0;
            this.Customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customers.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Customers.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.Customers.IconColor = System.Drawing.Color.Gainsboro;
            this.Customers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Customers.IconSize = 32;
            this.Customers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Customers.Location = new System.Drawing.Point(3, 537);
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
            this.Products.FlatAppearance.BorderSize = 0;
            this.Products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Products.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Products.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.Products.IconColor = System.Drawing.Color.Gainsboro;
            this.Products.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Products.IconSize = 32;
            this.Products.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Products.Location = new System.Drawing.Point(-3, 395);
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
            this.Orders.FlatAppearance.BorderSize = 0;
            this.Orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Orders.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Orders.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.Orders.IconColor = System.Drawing.Color.Gainsboro;
            this.Orders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Orders.IconSize = 32;
            this.Orders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Orders.Location = new System.Drawing.Point(-3, 324);
            this.Orders.Name = "Orders";
            this.Orders.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.Orders.Size = new System.Drawing.Size(200, 65);
            this.Orders.TabIndex = 5;
            this.Orders.Text = "Orders";
            this.Orders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Orders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Orders.UseVisualStyleBackColor = false;
            this.Orders.Click += new System.EventHandler(this.Orders_Click);
            // 
            // Dashboard
            // 
            this.Dashboard.FlatAppearance.BorderSize = 0;
            this.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Dashboard.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.Dashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.Dashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Dashboard.IconSize = 32;
            this.Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.Location = new System.Drawing.Point(0, 253);
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
            // LogoLyout
            // 
            this.LogoLyout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(19)))));
            this.LogoLyout.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoLyout.Location = new System.Drawing.Point(0, 0);
            this.LogoLyout.Name = "LogoLyout";
            this.LogoLyout.Size = new System.Drawing.Size(206, 176);
            this.LogoLyout.TabIndex = 3;
            this.LogoLyout.Paint += new System.Windows.Forms.PaintEventHandler(this.LogoLyout_Paint);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 828);
            this.Controls.Add(this.Cuerpo);
            this.Controls.Add(this.Nav);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Nav.ResumeLayout(false);
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
        private System.Windows.Forms.FlowLayoutPanel LogoLyout;
        private System.Windows.Forms.Panel Nav;
   
        private FontAwesome.Sharp.IconButton Home;
        private FontAwesome.Sharp.IconButton Settings;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

