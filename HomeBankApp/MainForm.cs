
using HomeBankApp.Managers;
using HomeBankApp.Models;

namespace HomeBankApp
{
    public partial class MainForm : Form
    {
        private User _user;

        public MainForm(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ManagerOperation.Manager = new DbManager();
            inputField.Controls[0].Visible = false;
            UpdateView();
        }

        private void buttonAddMoney_Click(object sender, EventArgs e)
        {
            if (inputField.Value == 0)
            {
                MessageBox.Show("Пожалуйста, введите ненулевое и положительное значение");
                return;
            }
            ManagerOperation.AddOperation(Convert.ToDouble(inputField.Value));
            UpdateView();
        }

        private void buttonRemoveMoney_Click(object sender, EventArgs e)
        {
            if (inputField.Value == 0)
            {
                MessageBox.Show("Пожалуйста, введите ненулевое и положительное значение");
                return;
            }
            ManagerOperation.AddOperation(-Convert.ToDouble(inputField.Value));
            UpdateView();
        }

        private void UpdateView()
        {
            dataGridViewOpeartions.Rows.Clear();
            foreach (var op in ManagerOperation.GetOperationsForCurrentMonth().Reverse())
                dataGridViewOpeartions.Rows.Add(op.Value, op.Date.ToString());
            outPutFirld.Text = ManagerOperation.GetTotalMoney().ToString();
        }

        private void buttonYearStatistic_Click(object sender, EventArgs e)
        {
            var negative = ManagerOperation.GetOperationsForCurrentYearNegative().Select(x => x.sumOfMonth).ToArray();
            var negativeDate = ManagerOperation.
                GetOperationsForCurrentYearNegative().
                Select(x => new DateTime(DateTime.Now.Year, x.monthNumber, 1).ToOADate()).ToArray();
            var positive = ManagerOperation.GetOperationsForCurrentYearPositive().Select(x => x.sumOfMonth).ToArray();
            var positiveDate = ManagerOperation.
                GetOperationsForCurrentYearPositive().
                Select(x => new DateTime(DateTime.Now.Year, x.monthNumber, 1).ToOADate()).ToArray();
            if (negative == null || negativeDate == null || positive == null || positiveDate == null) return;
            plotField.Plot.AddScatter(negativeDate, negative);
            plotField.Plot.AddScatter(positiveDate, positive);
            plotField.Plot.XAxis.DateTimeFormat(true);
            plotField.Plot.XLabel("Дата");
            plotField.Plot.YLabel("Рубли");
            plotField.Plot.Title("Статистика за текущий год");
            plotField.Refresh();
        }
    }
}