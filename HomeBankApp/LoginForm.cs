using HomeBankApp.Managers;

namespace HomeBankApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Registrable_MouseClick(object sender, MouseEventArgs e)
        {
            Hide();
            new RegistrationForm().ShowDialog();
            Show();
        }

        private void Registrlable_MouseEnter(object sender, EventArgs e)
        {
            registration.ForeColor = Color.White;
        }

        private void Registrlable_MouseLeave(object sender, EventArgs e)
        {
            registration.ForeColor = Color.Black;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            var user = AuthRegManager.Authorize(login.Text, password.Text);
            if (user == null)
            {
                MessageBox.Show("Неверный логин или пороль, возможно вам стоит зарегестрироваться!");
                return;
            }
            Hide();
            new MainForm(user).ShowDialog();
            Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ManagerOperation.Manager = new DbManager();
        }
    }
}
