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

namespace IT488_TheBigThreeServiceTicket
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source =K2107N0117911\SQLEXPRESS; Initial Catalog = TheBigThreeSupport; Integrated Security = True;");
        SqlCommand cmd;
        public Form3()
        {
            InitializeComponent();
        }



        void button1_Click(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = K2107N0117911\\SQLEXPRESS; Initial Catalog = TheBigThreeSupport; Integrated Security=True;Pooling=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select Ticket_Number, Ticket_Date, Customer_First_Name, Customer_Last_Name, Customer_Email, Customer_Phone, Ticket_Description From Service_Ticket Where Ticket_Number =@Ticket_Number ", con);
            cmd.Parameters.AddWithValue("@Ticket_Number", int.Parse(textBox1.Text));
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox2.Text = dr.GetValue(0).ToString();
                textBox3.Text = dr.GetValue(1).ToString();
                textBox4.Text = dr.GetValue(2).ToString();
                textBox5.Text = dr.GetValue(3).ToString();
                textBox6.Text = dr.GetValue(4).ToString();
                textBox7.Text = dr.GetValue(5).ToString();
                richTextBox1.Text = dr.GetValue(6).ToString();
            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var con = new SqlConnection(@"Data Source = K2107N0117911\SQLEXPRESS; Initial Catalog = TheBigThreeSupport; Integrated Security=True;");
            con.Open();
            var da = new SqlDataAdapter("SELECT * FROM Service_Ticket", con);
            var dtbl = new DataTable();
            da.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            con.Close();
        }
    }
}
