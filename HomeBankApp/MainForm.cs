namespace HomeBankApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            depositField.Controls[0].Visible = false;
            inputField.Controls[0].Visible = false;
            UpdateDeposit();
        }

     

        private void buttonRemoveMoney_Click(object sender, EventArgs e)
        {
            if (inputField.Value > 0)
                ManagerOperation.RemoveMoney(Convert.ToDouble(inputField.Value));
            else
                MessageBox.Show("Вводимое число должно быть строго больше нуля и не ровняться ему!");
            
            UpdateDeposit();
        }

        private void buttonAddMoney_Click(object sender, EventArgs e)
        {
            if (inputField.Value > 0)
                ManagerOperation.AddMoney(Convert.ToDouble(inputField.Value));
            else
                MessageBox.Show("Вводимое число должно быть строго больше нуля и не ровняться ему!");

            UpdateDeposit();
        }



        private void UpdateDeposit()
        {
            depositField.Value = Convert.ToDecimal(ManagerOperation.GetTotalMoney());

        }


    }
}