using DevTrust.Models;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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

namespace DevTrust
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DataGrid_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            DataGridRow row = (DataGridRow)(dataGrid.ItemContainerGenerator.ContainerFromItem(dataGrid.SelectedItem));
            if (row != null)
            {
                ContextMenu contextMenu = new ContextMenu();

                MenuItem exportCSV = new MenuItem();
                exportCSV.Header = "Export to CSV";
                exportCSV.Click += new RoutedEventHandler(ExportCSV_Click);
                contextMenu.Items.Add(exportCSV);

                MenuItem exportTXT = new MenuItem();
                exportTXT.Header = "Export to TXT";
                exportTXT.Click += new RoutedEventHandler(ExportTXT_Click);
                contextMenu.Items.Add(exportTXT);

                contextMenu.IsOpen = true;
            }
        }

        private void ExportCSV_Click(object sender, RoutedEventArgs e)
        {
            var selectedRows = dataGrid.SelectedItems.Cast<PersonModel>();
            var csvData = new StringBuilder();

            csvData.AppendLine("First Name,Last Name, Email, FullAddress");
            foreach (var row in selectedRows)
            {
                csvData.AppendLine(row.FirstName + "," + row.LastName + "," + row.Email + "," + row.FullAddress);
            }

            // Write the data to a file
            File.WriteAllText(@"C:\export.csv", csvData.ToString());

        }

        private void ExportTXT_Click(object sender, RoutedEventArgs e)
        {
            var selectedRows = dataGrid.SelectedItems.OfType<PersonModel>().ToList();
            var txtData = new StringBuilder();

            foreach (var selectedRow in selectedRows)
            {
                txtData.AppendLine("First Name: " + selectedRow.FirstName);
                txtData.AppendLine("Last Name: " + selectedRow.LastName);
                txtData.AppendLine("Email: " + selectedRow.Email);
                txtData.AppendLine("Full Address: " + selectedRow.FullAddress);
                txtData.AppendLine("");
            }

            // Write the data to a file
            File.WriteAllText(@"C:\export.txt", txtData.ToString());
        }

        private void dataGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            foreach (var column in dataGrid.Columns)
            {
                column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
            }
        }
    }
}

