using EmpWPF.Models;
using EmpWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
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

namespace EmpWPF.Views
{
    public partial class DepartmentDetails : UserControl
    {
        HttpClient client = new HttpClient();
        public List<Department> Departments { get; private set; }
        public string ShowPostMessage { get; private set; }
        public DepartmentDetails()
        {
            InitializeComponent();
        }
        private void BtnLoadEmployeeDetails_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new ViewEmployeeDetailsViewModel();
        }
        private void BtnLoadDepartmentDetails_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new DepartmentDetailsViewModel();
        }
        private void Dgdepartment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void BtnDelete_Clicked(object sender, RoutedEventArgs e)
        {
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
