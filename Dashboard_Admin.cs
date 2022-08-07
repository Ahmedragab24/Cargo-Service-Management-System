using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_Requirement_Management_System
{
    public partial class Dashboard_A : Form
    {
        public Dashboard_A()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Detail AD = new Admin_Detail();
            AD.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product_Detail PD = new Product_Detail();
            PD.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Jobs J = new Jobs();
            J.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home L = new Home();
            L.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Accepted Ac = new Accepted();
            Ac.Show();
            this.Hide();
        }
    }
}
