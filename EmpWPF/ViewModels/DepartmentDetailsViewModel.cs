using EmpWPF.Models;
using Newtonsoft.Json;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace EmpWPF.ViewModels
{
    public class DepartmentDetailsViewModel : BindableBase, INotifyPropertyChanged, IDataErrorInfo
    {
        // public ICommand MyCommand { get; set; }

        private int employeeID;
        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; OnPropertyChanged("EmployeeID"); }
        }

        private int departmentID;
        public int DepartmentID
        {
            get { return departmentID; }
            set { departmentID = value; OnPropertyChanged("DepartmentID"); }
        }

        private string departmentName;
        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; OnPropertyChanged("DepartmentName"); }
        }

        private bool _Change;
        public bool Change
        {
            get { return _Change; }
            set
            {
                _Change= value; OnPropertyChanged("Change");

            }
        }

        private bool add;
        public bool ADD
        {
            get { return add; }
            set { add = value; OnPropertyChanged("ADD"); }
        }

        private void changeButton()
        {
            ADD = false;
            Change = true;
        }

        public string Error
        {
            get
            {
                return null;
            }
        }

        public string this[string propertyName]
        {
            get
            {
                string result = String.Empty;
                switch (propertyName)
                {
                    case "EmployeeID":
                        if (EmployeeID != 0)
                            result = "Employee Id need";
                        else if (EmployeeID >= 10)
                            MessageBox.Show("Id Shoud be less than 10");
                        break;
                    case "DepartmentID":
                        if (DepartmentID != 0)
                            result = "Employee Id need";
                        else if (EmployeeID >= 10)
                            MessageBox.Show("Id Shoud be less than 10");
                        break;
                }
                return result;
            }
        }

        public DelegateCommand GetButtonClicked { get; set; }
        public Command PostAddButtonClicked { get; set; }
        public Command PostButtonClicked { get; set; }
        public Command DeleteButtonClicked { get; set; }
        public Command New { get; set; }

        private List<Department> departments;
        public List<Department> Departments
        {
            get { return departments; }
            set
            {
                departments = value;
                OnPropertyChanged("Departments");
            }

        }
        private Department _DepartmentList;
        public Department DepartmentList
        {
            get { return _DepartmentList; }
            set
            {
                _DepartmentList = value;
                OnPropertyChanged("DepartmentList");
                UpdateSelection();
                changeButton();

            }
        }

        private void UpdateSelection()
        {
            EmployeeID = DepartmentList.EmployeeID;
            DepartmentID = DepartmentList.DepartmentID;
            DepartmentName = DepartmentList.DepartmentName;


        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        HttpClient client = new HttpClient();

        private ObservableCollection<Department> _lstDepartment;

        public ObservableCollection<Department> LstDepartment
        {
            get { return _lstDepartment; }
            set
            {
                _lstDepartment = value;
                OnPropertyChanged(nameof(LstDepartment));
            }
        }

        public DepartmentDetailsViewModel()
        {
            //MyCommand = new Command(ExecuteMethod, canexecuteMethod);
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["BaseAddress"]);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            GetButtonClicked = new DelegateCommand(GetDepartmentDetails);
            PostAddButtonClicked = new Command(CreateDepartment,fill);
            PostButtonClicked = new Command(UpdateDepartmentDetails,Update);
            DeleteButtonClicked = new Command(DeleteDepartmentDetails,Delete);
            New = new Command(ClearSelection, (x) => true);
            GetDepartmentDetails();
        }

        private bool Delete(object arg)
        {
            if (employeeID != 0 && departmentID != 0 && departmentName !=String.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool Update(object arg)
        {
            if (employeeID != 0 && departmentID != 0 && departmentName != String.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool fill(object arg)
        {
            if (employeeID != 0 && departmentID != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ClearSelection(object param)
        {
            Clear();
        }

        private void Clear()
        {
            if (EmployeeID != 0)
            {
                EmployeeID = 0;
            }

            if (DepartmentID != 0)
            {
                DepartmentID = 0;
            }
            if (DepartmentName != null)
            {
                DepartmentName = String.Empty;
            }
            ADD = true;
            Change = false;
        }

        private void UpdateDepartmentDetails(object param)
        {
            Department dep = new Department()
            {
                EmployeeID = EmployeeID,
                DepartmentID = DepartmentID,
                DepartmentName = DepartmentName
            };
            var departDetails = PostCall(dep);
            if (departDetails.Result.StatusCode != System.Net.HttpStatusCode.Created)
            {
                string upd = ConfigurationManager.AppSettings["Update"];
                MessageBox.Show(upd);
                Clear();
            }
            else
            {
                string noupd = ConfigurationManager.AppSettings["Noupdate"];
                MessageBox.Show(noupd);
            }
            GetDepartmentDetails();
        }
        public void CreateDepartment(object param)
        {

            Department newDep = new Department()
            {
                EmployeeID = EmployeeID,
                DepartmentID = DepartmentID,
                DepartmentName = DepartmentName
            };

            var departDetails = PostAddCall(newDep);
            if (departDetails.Result.StatusCode != System.Net.HttpStatusCode.Created)
            {
                string add = ConfigurationManager.AppSettings["Add"];
                MessageBox.Show(add);
                Clear();
            }
            else
            {
                string noadd = ConfigurationManager.AppSettings["Noadd"];
                MessageBox.Show(noadd);
            }
            GetDepartmentDetails();
        }
        public static Task<HttpResponseMessage> PostCall<T>(T model) where T : class
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConfigurationManager.AppSettings["BaseAddress"]);
                    client.Timeout = TimeSpan.FromSeconds(900);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var stringContent = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
                    var response = client.PostAsync("api/employee/UpdateDepartmentDetails", stringContent);
                    response.Wait();
                    return response;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Task<HttpResponseMessage> PostAddCall<T>(T model) where T : class
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConfigurationManager.AppSettings["BaseAddress"]);
                    client.Timeout = TimeSpan.FromSeconds(900);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var stringContent = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
                    var response = client.PostAsync("api/employee/CreateDepartment", stringContent);
                    response.Wait();
                    return response;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async void GetDepartmentDetails()
        {
            var response = await client.GetStringAsync("api/employee/GetDepartmentDetails");
            var dep = JsonConvert.DeserializeObject<List<Department>>(response);
            Departments = dep;
        }

        private void ConfirmDelete()
        {
            Department dep = new Department()
            {
                EmployeeID = EmployeeID,
                DepartmentID = DepartmentID,
                DepartmentName = DepartmentName
            };
            var departDetails = PostDeleteCall(dep);
            if (departDetails.Result.StatusCode != System.Net.HttpStatusCode.Created)
            {
                string del = ConfigurationManager.AppSettings["Delete"];
                MessageBox.Show(del);
                Clear();
            }
            else
            {
                string nodel = ConfigurationManager.AppSettings["Nodelete"];
                MessageBox.Show(nodel);
            }
            GetDepartmentDetails();
        }
        private void DeleteDepartmentDetails(object param)
        {
            string con = ConfigurationManager.AppSettings["Conform"];
            string com = ConfigurationManager.AppSettings["ConformDel"];
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show(con, com, System.Windows.MessageBoxButton.YesNo, System.Windows.MessageBoxImage.Question);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                ConfirmDelete();
            }
        }

        public static Task<HttpResponseMessage> PostDeleteCall<T>(T model) where T : class
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConfigurationManager.AppSettings["BaseAddress"]);
                    client.Timeout = TimeSpan.FromSeconds(900);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var stringContent = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
                    var response = client.PostAsync("api/employee/DeleteDepartmentDetails", stringContent);
                    response.Wait();
                    return response;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


    }

}
