using HomeBankApp.Contexts;
using HomeBankApp.Models;
using HomeBankApp;
using ScottPlot;
using System.Diagnostics;

namespace TestProject
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            var fc = new FileContext()
            {
                Operations = new List<Operation> { new Operation { Value = 3232 } },
                Users = new List<User> { new User { Name = "Èãàð¸ê" } }
            };
            JsonConverter.Serialize(fc, "fileContext.json");

            var context = JsonConverter.Deserialize("fileContext.json");

            Debug.WriteLine(context.Users[0].Name);

            // create sample X/Y data
            //int pointCount = 1000000;
            //double[] x = DataGen.Consecutive(pointCount);
            //double[] sin = DataGen.Sin(pointCount);
            //double[] cos = DataGen.Cos(pointCount);
            //plotField.Plot.AddScatter(x,sin);
            //plotField.Refresh();

        }
    }
}