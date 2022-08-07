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
    public partial class View_Product_Info : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Futuemind\Documents\BRMS.db.mdf;Integrated Security=True;Connect Timeout=30");
        public View_Product_Info()
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
            View_Prod_Info_GV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void View_Product_Info_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dashboard_C DC = new Dashboard_C();
            DC.Show();
            this.Hide();
        }
    }
}
