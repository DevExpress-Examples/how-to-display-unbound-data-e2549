using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using DevExpress.Xpf.Grid;

namespace Display_Unbound_Data {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            grid.DataSource = ProductList.GetData();
        }
        void grid_CustomUnboundColumnData(object sender, GridColumnDataEventArgs e) {
            if(e.IsGetData) {
                int price = Convert.ToInt32(e.GetListSourceFieldValue("UnitPrice"));
                int unitsOnOrder = Convert.ToInt32(e.GetListSourceFieldValue("Quantity"));
                e.Value = price * unitsOnOrder;
            }
        }
    }
}
