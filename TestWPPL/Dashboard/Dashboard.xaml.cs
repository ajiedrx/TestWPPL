using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Velacro.Basic;
using Velacro.Chart.LineChart;
using Velacro.UIElements.Basic;

namespace TestWPPL.Dashboard {
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : MyPage{
        private IMyLineChart lineChart;
        private BuilderLineChart builderLineChart;
        public Dashboard() {
            InitializeComponent();
            builderLineChart = new BuilderLineChart();
            MyList<double> values = new MyList<double>(){ 10, 20, 30, 40, 50 };
            lineChart = builderLineChart
                .activate(this, "lineChart_chr")
                .addSeries("Series1", values);
        }
    }
}
