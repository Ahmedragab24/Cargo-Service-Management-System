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
    public partial class Product_Detail : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Futuemind\Documents\BRMS.db.mdf;Integrated Security=True;Connect Timeout=30");
        public Product_Detail()
        {
            InitializeComponent();
        }
        void populate()
        {
            Con.Open();
            string query = "select * from ProductTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ProductGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dashboard_A H = new Dashboard_A();
            H.Show();
            this.Hide();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update ProductTbl set Vehicle = '" + Vehicle.Text + "' , Assistants = '" + Assistants.Text + "', Price = '" + Price.Text + "' where Product_Id = " + Product_Id.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Product Successfully Updated");
            Con.Close();
            populate();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            if (Product_Id.Text == "" || Vehicle.Text == "" || Assistants.Text == "" || Price.Text == "")
                MessageBox.Show("No Empty Fills Accepted");
            else
            {
                Con.Open();
                String query = "insert into ProductTbl values (" + Product_Id.Text + " ,'" + Vehicle.Text + "', " + Assistants.Text + " ,'" + Price.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Added");
                Con.Close();
                populate();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Product_Id.Text == "")
                MessageBox.Show("Enter the Product ID");
            else
            {
                Con.Open();
                String query = "delete from ProductTbl where Product_Id = " + Product_Id.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void Product_Detail_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void Product_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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