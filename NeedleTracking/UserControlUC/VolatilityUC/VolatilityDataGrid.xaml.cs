﻿using System;
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

namespace NeedleTracking.UserControlUC.VolatilityUC
{
    /// <summary>
    /// Interaction logic for VolatilityDataGrid.xaml
    /// </summary>
    public partial class VolatilityDataGrid : UserControl
    {
        public VolatilityDataGrid()
        {
            InitializeComponent();
            Datagrid.Loaded += SetMinWidths;
        }
        public void SetMinWidths(object source, EventArgs e)
        {
            foreach (var column in Datagrid.Columns)
            {
                column.MinWidth = column.ActualWidth;
                column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
            }
        }
    }
}
