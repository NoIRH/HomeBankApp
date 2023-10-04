using HomeBankApp.Managers;

namespace HomeBankApp
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void authorization_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void authorization_MouseEnter(object sender, EventArgs e)
        {
            authorization.ForeColor = SystemColors.Highlight;
        }

        private void authorization_MouseLeave(object sender, EventArgs e)
        {
            authorization.ForeColor = SystemColors.ControlText;
        }

        private void buttonRedistration_Click(object sender, EventArgs e)
        {
            if (AuthRegManager.Authorize(login.Text, password.Text) != null)
            {
                MessageBox.Show("Такой пользователь уже есть!");
                return;
            }
            var user = AuthRegManager.Register(login.Text, password.Text);
            Hide();
            new MainForm(user).ShowDialog();
            Close();
        }
    }
}
