using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeBankApp
{
    public partial class RegistrationForm1 : Form
    {
        public RegistrationForm1()
        {
            InitializeComponent();
            Size = new Size(493, 493);

        }

        private void RegistrationForm1_Load(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void Authorization_label_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void Authorization_label_MouseEnter(object sender, EventArgs e)
        {
            Authorization_label.ForeColor = Color.White;
        }

        private void Authorization_label_MouseLeave(object sender, EventArgs e)
        {
            Authorization_label.ForeColor = Color.Black;
        }
    }
}
