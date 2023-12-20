using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility;
using Syncfusion.Maui.Data;
using Syncfusion.Maui.DataGrid;
using Syncfusion.Maui.DataGrid.Helper;
using System.Diagnostics;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var record = button.BindingContext as Employee;
            var recordRowIndex = viewModel.Employees.IndexOf(record);
            var rowIndex = datagrid.ResolveToRowIndex(recordRowIndex);
        }
    }
}
