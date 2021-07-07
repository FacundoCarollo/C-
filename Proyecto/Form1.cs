using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
namespace Proyecto
{


    public partial class Form1 : Form
    {
        private IconButton currentBtn;
        private Panel leftBorder;



        public Form1()
        {
            InitializeComponent();
            leftBorder = new Panel();
            leftBorder.Size = new Size(7, 65);
            Main.Controls.Add(leftBorder);

        }
        private void ActivateButtom(object senderBtn, Color color)
        {
            DisableButtom();
            if (senderBtn != null)
            {
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(15, 17, 19);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleCenter;

                leftBorder.BackColor = color;
                leftBorder.Location = new Point(0, currentBtn.Location.Y);
                leftBorder.Visible = true;
                leftBorder.BringToFront();
            }
        }


        private struct RgbColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(60, 82, 45);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(64, 224, 208);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(255, 255, 0);
            public static Color color7 = Color.FromArgb(238, 107, 0);
            public static Color color8 = Color.FromArgb(0, 104, 0);
        }
      





        private void DisableButtom()
        {
            if (currentBtn != null)
            {

                currentBtn.BackColor = Color.FromArgb(15, 17, 19);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


  

        private void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            ActivateButtom(sender, RgbColors.color1);
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            ActivateButtom(sender, RgbColors.color2);
        }

        private void Orders_Click(object sender, EventArgs e)
        {
            ActivateButtom(sender, RgbColors.color3);
        }

        private void Products_Click(object sender, EventArgs e)
        {
            ActivateButtom(sender, RgbColors.color4);
        }

        private void Selling_Click(object sender, EventArgs e)
        {
            ActivateButtom(sender, RgbColors.color5);
        }

        private void Customers_Click(object sender, EventArgs e)
        {
            ActivateButtom(sender, RgbColors.color6);
        }

        private void Marketing_Click(object sender, EventArgs e)
        {
            ActivateButtom(sender, RgbColors.color7);
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            ActivateButtom(sender, RgbColors.color8);
        }

        private void LogoLyout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}

