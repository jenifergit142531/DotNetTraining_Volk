using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookStoreApplication
{
    public partial class ProductForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=REV-PG02C4Y5;Initial Catalog=Demo;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");

        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demoDataSet3.EStock' table. You can move, or remove it, as needed.
            this.eStockTableAdapter.Fill(this.demoDataSet3.EStock);
            // TODO: This line of code loads data into the 'demoDataSet2.Eproduct' table. You can move, or remove it, as needed.
            this.eproductTableAdapter.Fill(this.demoDataSet2.Eproduct);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_deleteproduct", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pid", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Product Info deleted");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_updateproduct", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pid", textBox1.Text);
            cmd.Parameters.AddWithValue("@pname", textBox2.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Product Info Updated");
        }
    }
}
