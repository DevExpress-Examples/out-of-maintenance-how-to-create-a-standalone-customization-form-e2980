using System.Windows;

namespace DXPivotGrid_StandaloneFieldList {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            pivotGridControl1.DataSource = 
                (new DataSet1TableAdapters.SalesPersonTableAdapter()).GetData();
        }
    }
}
