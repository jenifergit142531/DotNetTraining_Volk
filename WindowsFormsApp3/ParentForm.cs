using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp3
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();

        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            if(cd.ShowDialog()==DialogResult.OK)
            {
                //string str = null;
                string str = cd.Color.Name;
                MessageBox.Show(str);
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            if(fd.ShowDialog() == DialogResult.OK)
            {
                string name = fd.Font.Name;
                float size = fd.Font.Size;
                MessageBox.Show("You chose"+name+"with the size"+size);

            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            if(od.ShowDialog()==DialogResult.OK)
            {
                string filename = od.FileName;
                MessageBox.Show(filename);
                

            }
            
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument pdoc = new PrintDocument();
            pdoc.DocumentName = "My Document";
            pd.Document = pdoc;
            pd.AllowSelection = true;
            pd.AllowSomePages = true;
            if(pd.ShowDialog()==DialogResult.OK)
            {
                pdoc.Print();
            }
            else
            {
                MessageBox.Show("Print cancelled");
            }
        }
    }
}
