

using ScottPlot;

namespace TestProject
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // create sample X/Y data
            int pointCount = 1000000;
            double[] x = DataGen.Consecutive(pointCount);
            double[] sin = DataGen.Sin(pointCount);
            double[] cos = DataGen.Cos(pointCount);
            plotField.Plot.AddScatter(x,sin);
            plotField.Refresh();

        }
    }
}