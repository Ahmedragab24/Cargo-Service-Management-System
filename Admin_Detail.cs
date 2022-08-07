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
    public partial class Admin_Detail : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Futuemind\Documents\BRMS.db.mdf;Integrated Security=True;Connect Timeout=30");
        public Admin_Detail()
        {
            InitializeComponent();
        }
        void populate()
        {
            Con.Open();
            string query = "select * from AdminTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            AdminGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Dashboard_A H = new Dashboard_A();
            H.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AdId.Text == "" || AdName.Text == "" || AdPass.Text == "")
                MessageBox.Show("No Empty Fills Accepted");
            else
            {
                Con.Open();
                String query = "insert into AdminTbl values (" + AdId.Text + " ,'" + AdName.Text + "'," + AdPass.Text + ")";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Admin Successfully Added");
                Con.Close();
                populate();
            }
        }

        private void Admin_Detail_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (AdId.Text == "")
                MessageBox.Show("Enter the Admin ID");
            else
            {
                Con.Open();
                String query = "delete from AdminTbl where AdId = " + AdId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Admin Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update AdminTbl set AdName = '" + AdName.Text + "' ,AdPass = '" + AdPass.Text + "' where AdId = " + AdId.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Admin Successfully Updated");
            Con.Close();
            populate();

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
