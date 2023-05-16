using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class GDIForm : Form
    {
        public GDIForm()
        {
            InitializeComponent();
        }

        private void GDIForm_Paint(object sender, PaintEventArgs e)
        {
            // creating graphics object

            Graphics g = e.


            //Create three different types of brushes

            SolidBrush redColour = new SolidBrush(Color.Red);

            Image img = new Bitmap("C:/Users/JeniferY/texture.jpeg");
            TextureBrush txtBrush = new TextureBrush(img);

            LinearGradientBrush lgBrush = new LinearGradientBrush(new Rectangle(10, 10, 10, 10),
                Color.Green, Color.Blue, 45);


            //Create pens from brushes

            Pen p1 = new Pen(redColour, 3);
            Pen p2 = new Pen(txtBrush, 50);
            Pen p3 = new Pen(lgBrush, 60);

            // Drawing objects

            g.DrawEllipse(p1, 150, 150, 80, 50);
            g.DrawRectangle(p2, 100, 100, 50, 30);
            g.DrawEllipse(p3, 30, 30, 30, 20);

            //get pen types

            string str = "pen 1 type :" +
                p1.PenType.ToString() + "\n";
            str += "pen 2 type :" +
                p2.PenType.ToString() + "\n";
            str += "pen 3 type :" +
                p3.PenType.ToString() + "\n";

            MessageBox.Show(str);

            //dispose the object

            p1.Dispose();
            p2.Dispose();
            p3.Dispose();
            redColour.Dispose();
            txtBrush.Dispose();
            lgBrush.Dispose();
            img.Dispose();
            g.Dispose();

        }

        private void GDIForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}

//C:\Users\JeniferY\Desktop\MSatak\WindowsFormsApp3\WindowsFormsApp3\