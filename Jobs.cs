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
    public partial class Jobs : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Futuemind\Documents\BRMS.db.mdf;Integrated Security=True;Connect Timeout=30");
        public Jobs()
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
            JobsGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Jobs_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard_A DA = new Dashboard_A();
            DA.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Hire_Id.Text == "")
                MessageBox.Show("Enter the Hire ID");
            else
            {
                Con.Open();
                String query = "delete from Hire_Tbl where Hire_Id = " + Hire_Id.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Hire Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Accepted Ac = new Accepted();
            Ac.Show();
            this.Hide();
        }
    }
}
