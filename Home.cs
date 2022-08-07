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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn_A A = new LogIn_A();
            A.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogIn_C C = new LogIn_C();
            C.Show();
            this.Hide();
        }
    }
}
