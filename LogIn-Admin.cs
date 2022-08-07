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
    public partial class LogIn_A : Form
    {
        public LogIn_A()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard_A DA = new Dashboard_A();
            DA.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
    }
}
