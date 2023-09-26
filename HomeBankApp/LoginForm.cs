using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeBankApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Width = 493;
            this.Height = 493;
        }

        private void LoginText_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Registrable_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            RegistrationForm1 registrationForm1 = new RegistrationForm1();
            registrationForm1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Registrlable_Click(object sender, EventArgs e)
        {

        }

        private void Registrlable_MouseEnter(object sender, EventArgs e)
        {
            Registrlable.ForeColor = Color.White;
        }

        private void Registrlable_MouseLeave(object sender, EventArgs e)
        {
            Registrlable.ForeColor = Color.Black;
        }
    }
}
