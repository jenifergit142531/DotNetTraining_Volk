using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have successfully registered with us");
            panel1.Show();
            label8.Text = textBox2.Text;
            if(radioButton1.Checked)
            {
                label9.Text = radioButton1.Text;
            }
            else
            {
                label9.Text = radioButton2.Text;
            }
            if(checkBox1.Checked==true || checkBox2.Checked==true || checkBox3.Checked==true)
            {
                label10.Text = checkBox1.Text;
                label13.Text = checkBox2.Text;
                label14.Text = checkBox3.Text;
            }
            else
            {
                label10.Hide();
                label13.Hide();
                label14.Hide();
            }

            label10.Text = comboBox1.SelectedItem.ToString();
            label12.Text = richTextBox1.Text;
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
          
            panel1.Hide();
        }

        
    }
}
