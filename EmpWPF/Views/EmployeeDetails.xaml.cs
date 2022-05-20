using EmpWPF.Models;
using EmpWPF.ViewModels;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace EmpWPF.Views
{
    public partial class EmployeeDetails : UserControl
    {
        HttpClient client = new HttpClient();
        public List<Employee> Employees { get; private set; }
        public string ShowPostMessage { get; private set; }
        public EmployeeDetails()
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
        private void Dgemployee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void BtnDelete_Clicked(object sender, RoutedEventArgs e)
        {
        }
       /* public void clearData()
        {
            TextBoxID.Clear();
            TextBoxName.Clear();
            TextBlockAddress1.Clear();
            TextBoxAddress2.Clear();
            TextBoxPhoneNumber.Clear();
            TextBoxFatherName.Clear();
            TextBoxMotherName.Clear();
            TextBoxState.Clear();
            TextBoxAge.Clear();

        }
        private void ButtonNew_Click(object sender, RoutedEventArgs e)
        {
            clearData();
        }*/


        
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void TextBoxID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
