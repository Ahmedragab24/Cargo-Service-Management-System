using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Business_Requirement_Management_System
{
    public partial class Customer_Detail : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Futuemind\Documents\BRMS.db.mdf;
Integrated Security=True;Connect Timeout=30");
        public Customer_Detail()
        {
            InitializeComponent();
        }
        void populate()
        {
            Con.Open();
            string query = "select * from CustomerTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CustomerGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update CustomerTbl set Cust_name = '" + Cust_name.Text + "' , Contact_no = '" + Contact_no.Text + "', " +
                "Cust_Address = '"+Cust_Address.Text+"', Cust_pass = '"+Cust_pass.Text+"'  where Cust_Id = " + Cust_Id.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Admin Successfully Updated");
            Con.Close();
            populate();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dashboard_C H = new Dashboard_C();
            H.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Cust_Id.Text == "" || Cust_name.Text == "" || Contact_no.Text == "" || Cust_Address.Text == "" || Cust_pass.Text == "")
                MessageBox.Show("No Empty Fills Accepted");
            else
            {
                Con.Open();
                String query = "insert into CustomerTbl values (" + Cust_Id.Text + " ,'" + Cust_name.Text + "', " + Contact_no.Text + " ," +
                    "'" + Cust_Address.Text + "' , " + Cust_pass.Text + ")";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Added");
                Con.Close();
                populate();
            }
        }

        private void Customer_Detail_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Cust_Id.Text == "")
                MessageBox.Show("Enter the Customer ID");
            else
            {
                Con.Open();
                String query = "delete from CustomerTbl where Cust_Id = " + Cust_Id.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (Controls) =>
            {
                foreach (Control control in Controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);


            };
            func(Controls);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
    }
}
