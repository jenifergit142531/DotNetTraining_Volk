using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreApplication
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=REV-PG02C4Y5;Initial Catalog=Demo;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
        private BindingSource bs=new BindingSource();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into bookstore values(@bname,@aname,@purchasedate,@quantity,@price)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@bname", textBox1.Text);
                cmd.Parameters.AddWithValue("@aname", textBox2.Text);
                cmd.Parameters.AddWithValue("@purchasedate", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@quantity", textBox4.Text);
                cmd.Parameters.AddWithValue("@price", textBox3.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Book added to the cart succesfully");
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from bookstore", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
          
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update bookstore set aname=@aname,purchasedate=@purchasedate,quantity=@quantity,price=@price where bname=@bname", con);
            cmd.CommandType = CommandType.Text;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@bname", textBox1.Text);
            cmd.Parameters.AddWithValue("@aname", textBox2.Text);
            cmd.Parameters.AddWithValue("@purchasedate", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@quantity", textBox4.Text);
            cmd.Parameters.AddWithValue("@price", textBox3.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Book updated to the cart succesfully");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from bookstore where bname=@bname", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@bname", textBox1.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Book is deleted");

        }

        private void select_Click(object sender, EventArgs e)
        {
            using(SqlConnection con=new SqlConnection("Data Source=REV-PG02C4Y5;Initial Catalog=Demo;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False"))
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from gaming", con);
                //DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                dataGridView1.Visible = true;

            }
        }
    }
}
