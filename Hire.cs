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
    public partial class Hire : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Futuemind\Documents\BRMS.db.mdf;Integrated Security=True;Connect Timeout=30");
        public Hire()
        {
            InitializeComponent();
        }
        void populate()
        {
            Con.Open();
            string query = "select * from Hire_Tbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            HireGV.DataSource = ds.Tables[0];
            Con.Close();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            Dashboard_C H = new Dashboard_C();
            H.Show();
            this.Hide();
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

        private void button3_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void Hire_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Hire_Id.Text == "" || Date.Text == "" || From.Text == "" || To.Text == "")
                MessageBox.Show("No Empty Fills Accepted");
            else
            {
                Con.Open();
                String query = "insert into Hire_Tbl values (" + Hire_Id.Text + " ,'" + Date.Text + "','" + From.Text + "' , '"+To.Text+"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Hire Info Successfully Added");
                Con.Close();
                populate();
            }
        }

       
    }

      
    }

     
        
    

