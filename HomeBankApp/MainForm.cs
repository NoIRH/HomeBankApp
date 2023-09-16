using HomeBankApp.Models;

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
            inputField.Controls[0].Visible = false;
            UpdateView();
        }

        private void buttonAddMoney_Click(object sender, EventArgs e)
        {
            if (inputField.Value == 0)
            {
                MessageBox.Show("please enter not zero");
                return;
            }
            ManagerOperation.AddMoney(Convert.ToDouble(inputField.Value));
            UpdateView();
        }

        private void buttonRemoveMoney_Click(object sender, EventArgs e)
        {
            if (inputField.Value == 0)
            {
                MessageBox.Show("please enter not zero");
                return;
            }
            ManagerOperation.AddMoney(-Convert.ToDouble(inputField.Value));
            UpdateView();
        }
        private void UpdateView()
        {
            dataGridViewOpeartions.Rows.Clear();
            foreach (var op in ManagerOperation.GetOperationsByCurrentMonth())
                dataGridViewOpeartions.Rows.Add(op.Value, op.Date.ToString());
            outPutFirld.Text = ManagerOperation.GetTotalMoney().ToString();
        }

        private void buttonYearStatistic_Click(object sender, EventArgs e)
        {

        }
    }
}