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
            this.Width = 493;
            this.Height = 493;

        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
