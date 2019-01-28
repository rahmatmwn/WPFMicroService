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
using WPF.BussinessLogic.Services;
using WPF.BussinessLogic.Services.Master;
using WPF.DataAccess.Model;
using WPF.DataAccess.Params;

namespace BootcampWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Suppliers supplier = new Suppliers();
        MyContext _contex = new MyContext();
        ISupplierService supplierService = new SupplierService();
        SupplierParam supplierParam = new SupplierParam();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Savebutton_Click(object sender, RoutedEventArgs e)
        {
            //if (String.IsNullOrWhiteSpace(NametextBox.Text) == true)
            //{
            //    MessageBox.Show("Don't Input null or White Space");
            //}
            //else
            //{
            //    supplier.Name = NametextBox.Text;
            //    supplier.CreateDate = DateTimeOffset.Now.LocalDateTime;
            //    supplier.JoinDate = DateTimeOffset.Now.LocalDateTime;
            //    _contex.Suppliers.Add(supplier);
            //    var result = 0;
            //    result = _contex.SaveChanges();
            //    if (result == 0)
            //    {
            //        MessageBox.Show("Failed");
            //        NametextBox.Text = "";
            //    }
            //    else
            //    {
            //        MessageBox.Show("Success");
            //        NametextBox.Text = "";
            //    }
            //}
            supplierParam.Name = NametextBox.Text;
            supplierParam.CreateDate = DateTimeOffset.Now.LocalDateTime;
            supplierParam.JoinDate = DateTimeOffset.Now.LocalDateTime;
            supplierService.Insert(supplierParam);
            
            
        }

        private void NametextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("^[a-zA-Z. ]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
        }

        private void NametextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CountTextBox.Text = NametextBox.Text.Length.ToString();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            SupplierGrid.ItemsSource = supplierService.Get();
            SupplierComboBox.ItemsSource = supplierService.Get();
        }

        private void SupplierGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void SupplierGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object item = SupplierGrid.SelectedItem;
            NametextBox.Text = (SupplierGrid.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
            
        }

        private void SupplierComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //TextBox.Text = SupplierComboBox.SelectedValue.ToString();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
                SupplierGrid.ItemsSource = supplierService.Search(SearchTextBox.Text,SearchComboBox.Text);
        }
    }
}
