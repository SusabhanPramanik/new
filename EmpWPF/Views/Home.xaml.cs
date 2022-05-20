using EmpWPF.ViewModels;
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
using System.Windows.Shapes;

namespace EmpWPF.Views
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }
        private void BtnLoadEmployeeDetails_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new ViewEmployeeDetailsViewModel();
        }
        private void BtnLoadDepartmentDetails_Clicked(object sender, RoutedEventArgs e)
        {
            // DataContext = new EmployeeDetails();
            DataContext = new DepartmentDetailsViewModel();
            //  DataContext = new DepartmentDetails();
        }
    }
}
