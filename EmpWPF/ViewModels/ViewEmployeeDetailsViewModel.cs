using EmpWPF.Models;
using Newtonsoft.Json;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections;
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

namespace EmpWPF.ViewModels
{
    public class ViewEmployeeDetailsViewModel : INotifyPropertyChanged, IDataErrorInfo
    {
        private bool _Change;

        public bool Change
        {
            get { return _Change; }
            set
            {
                _Change = value; OnPropertyChanged("Change");

            }
        }

        private bool add;
        public bool ADD
        {
            get { return add; }
            set { add = value; OnPropertyChanged("ADD"); }
        }


        private void ChangeButton()
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
                string pattern = "^[A-Za-z][a-zA-Z\\s]*$";
                Regex Validate = new Regex(pattern);

                switch (propertyName)
                {
                    case "EmployeeId":
                        if (EmployeeID != 0)
                            result = "Employee Id need";
                       
                        break;

                    case "EmployeeName":
                        if (String.IsNullOrEmpty(EmployeeName))
                            result = "Employee Name need";

                        else if (!(EmployeeName.Length <= 15))
                        {
                            string error = ConfigurationManager.AppSettings["EmpError2"];
                            MessageBox.Show(error);
                        }

                        else if (!(Validate.IsMatch(EmployeeName)))
                            MessageBox.Show("Special charecter not allowed");
                        break;

                    case "Address1":
                        if (string.IsNullOrEmpty(Address1))
                            result = "1st addreess needed";
                        else if (!(Address1.Length <= 50))
                            MessageBox.Show("Adress should be less than 50");

                        break;
                    case "Address2":
                        if (string.IsNullOrEmpty(Address2))
                            result = "2nd Address needed";
                        break;
                    case "PhoneNumber":
                        if (PhoneNumber != 0)
                            result = " Phone number should be entered ";
                        break;

                    case "FatherName":
                        if (string.IsNullOrEmpty(FatherName))
                            result = "FatherName needed";
                        else if (!(FatherName.Length <= 15))
                        {
                            string error = ConfigurationManager.AppSettings["EmpError2"];
                            MessageBox.Show(error);
                        }
                        else if (!(Validate.IsMatch(FatherName)))
                            MessageBox.Show("Special charecter not allowed");
                        break;
                    case "MotherName":
                        if (string.IsNullOrEmpty(MotherName))
                            result = "MotherName needed";
                        else if (!(MotherName.Length <= 15))
                        {
                            string error = ConfigurationManager.AppSettings["EmpError2"];
                            MessageBox.Show(error);
                        }
                        else if (!(Validate.IsMatch(MotherName)))
                            MessageBox.Show("Special charecter not allowed");
                        break;
                    case "State":
                        if (string.IsNullOrEmpty(State))
                            result = "State needed";
                        else if (!(State.Length <= 10))
                        {
                            string error1 = ConfigurationManager.AppSettings["EmpError1"];
                            MessageBox.Show(error1);
                        }
                        break;
                }
                return result;
            }

        }


        public DelegateCommand GetButtonClicked { get => getButtonClicked; set => getButtonClicked = value; }
        public Command PostAddButtonClicked { get => postAddButtonClicked; set => postAddButtonClicked = value; }

        public Command PostButtonClicked { get => postButtonClicked; set => postButtonClicked = value; }
        public DelegateCommand DeleteButtonClicked { get => deleteButtonClicked; set => deleteButtonClicked = value; }

        private List<Employee> employees;
        public List<Employee> Employees
        {
            get { return employees; }
            set
            {
                employees = value;
                OnPropertyChanged("Employees");
            }

        }
        private Employee _EmployeeList;
        public Employee EmployeeList
        {
            get { return _EmployeeList; }
            set
            {
                _EmployeeList = value;
                OnPropertyChanged("EmployeeList");
                UpdateSelection();
                ChangeButton();
            }
        }

        private void UpdateSelection()
        {
            EmployeeID = EmployeeList.EmployeeID;
            EmployeeName = EmployeeList.EmployeeName;
            Address1 = EmployeeList.Address1;
            Address2 = EmployeeList.Address2;
            PhoneNumber = EmployeeList.PhoneNumber;
            FatherName = EmployeeList.FatherName;
            MotherName = EmployeeList.MotherName;
            DOB = EmployeeList.DOB;
            State = EmployeeList.State;
            Age = EmployeeList.Age;
        }

        public event PropertyChangedEventHandler PropertyChanged;


        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        HttpClient client = new HttpClient();

        private int employeeID;
        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; OnPropertyChanged("EmployeeID"); }
        }

        private string employeeName;
        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; OnPropertyChanged("EmployeeName"); }
        }

        private string address1;
        public string Address1
        {
            get { return address1; }
            set { address1 = value; OnPropertyChanged("Address1"); }
        }

        private string address2;
        public string Address2
        {
            get { return address2; }
            set { address2 = value; OnPropertyChanged("Address2"); }
        }

        private int phoneNumber;
        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; OnPropertyChanged("PhoneNumber"); }
        }

        private string fatherName;
        public string FatherName
        {
            get { return fatherName; }
            set { fatherName = value; OnPropertyChanged("FatherName"); }
        }

        private string motherName;
        public string MotherName
        {
            get { return motherName; }
            set { motherName = value; OnPropertyChanged("MotherName"); }
        }

        private DateTime dOB;
        public DateTime DOB
        {
            get { return dOB; }
            set { dOB = value; OnPropertyChanged("DOB"); }
        }

        private string state;
        public string State
        {
            get { return state; }
            set { state = value; OnPropertyChanged("State"); }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; OnPropertyChanged("Age"); }
        }

        private ObservableCollection<Employee> _lstEmployee;
        private DelegateCommand getButtonClicked;
        private Command postAddButtonClicked;
        private Command postButtonClicked;
        private DelegateCommand deleteButtonClicked;

        public ObservableCollection<Employee> LstEmployee
        {
            get { return _lstEmployee; }
            set
            {
                _lstEmployee = value;
                OnPropertyChanged(nameof(LstEmployee));
            }
        }

        public Command New { get; set; }


        public ViewEmployeeDetailsViewModel()
        {
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["BaseAddress"]);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            GetButtonClicked = new DelegateCommand(GetEmployeeFullDetails);
            PostAddButtonClicked = new Command(Display, fill1);
            PostButtonClicked = new Command(UpdateEmployeeDetails, Update);
            DeleteButtonClicked = new DelegateCommand(DeleteEmployeeDetails);
            New = new Command(ClearSelection, (x)=>true);
            GetEmployeeFullDetails();
            ADD = true;

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

            if (EmployeeName != null)
            {
                EmployeeName = String.Empty;
            }
            if (FatherName != null)
            {
                FatherName = String.Empty;
            }
            if (MotherName != null)
            {
                MotherName = String.Empty;
            }
            if (Address1 != null)
            {
                Address1 = String.Empty;
            }
            if (Address2 != null)
            {
                Address2 = String.Empty;
            }
            if (DOB != null)
            {
                DOB = DateTime.Now;
            }
            if (PhoneNumber != 0)
            {
                PhoneNumber = 0;
            }
            if (State != null)
            {
                State = String.Empty;
            }
            if (Age != 0)
            {
                Age = 0;
            }

            ADD = true;
            Change = false;
        }

        private bool Update(object arg)
        {
            if (employeeID != 0 && PhoneNumber != 0 && Age != 0 && EmployeeName != string.Empty && Address1 != string.Empty && Address2 != string.Empty && FatherName != string.Empty && MotherName != string.Empty && State != string.Empty)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        private bool fill1(object arg)
        {
            if (employeeID != 0 && PhoneNumber != 0 && Age != 0 && EmployeeName != string.Empty && Address1 != string.Empty && Address2 != string.Empty && FatherName != string.Empty && MotherName != string.Empty && State != string.Empty)
            {
                return true;
            }

            else
            {
                return false;
            }


        }

        private void UpdateEmployeeDetails(object arg)
        {
            Employee emp = new Employee()
            {
                EmployeeID = EmployeeID,
                EmployeeName = EmployeeName,
                Address1 = Address1,
                Address2 = Address2,
                PhoneNumber = PhoneNumber,
                FatherName = FatherName,
                MotherName = MotherName,
                DOB = DOB,
                State = State,
                Age = Age
            };
            var employeeFullDetails = PostCall(emp);
            if (employeeFullDetails.Result.StatusCode != System.Net.HttpStatusCode.Created)
            {
                string empupd = ConfigurationManager.AppSettings["EmpUpdate"];
                MessageBox.Show(empupd);
                Clear();
            }
            else
            {
                string empnoupd = ConfigurationManager.AppSettings["EmpNoupdate"];
                MessageBox.Show(empnoupd);
            }
            GetEmployeeFullDetails();
        }
        private void Display(object prama)
        {
            Employee newEmp = new Employee()
            {
                EmployeeID = EmployeeID,
                EmployeeName = EmployeeName,
                Address1 = Address1,
                Address2 = Address2,
                PhoneNumber = PhoneNumber,
                FatherName = FatherName,
                MotherName = MotherName,
                DOB = DOB,
                State = State,
                Age = Age
            };
            var employeeFullDetails = PostAddCall(newEmp);
            if (employeeFullDetails.Result.StatusCode != System.Net.HttpStatusCode.OK)
            {
                string empadd = ConfigurationManager.AppSettings["EmpAdd"];
                MessageBox.Show(empadd);
                Clear();
            }
            else
            {
                string empnoadd = ConfigurationManager.AppSettings["EmpNoadd"];
                MessageBox.Show("Employee Details added");
            }
            GetEmployeeFullDetails();
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
                    var response = client.PostAsync("api/employee/UpdateEmployeeDetails", stringContent);
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
                    var response = client.PostAsync("api/employee/Display", stringContent);
                    response.Wait();
                    return response;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async void GetEmployeeFullDetails()
        {
            var response = await client.GetStringAsync("api/employee/GetEmployeeFullDetails");
            var emp = JsonConvert.DeserializeObject<List<Employee>>(response);
            Employees = emp;
        }

        private void ConformDelete()
        {
            Employee emp = new Employee()
            {
                EmployeeID = EmployeeID,
                EmployeeName = EmployeeName,
                Address1 = Address1,
                Address2 = Address2,
                PhoneNumber = PhoneNumber,
                FatherName = FatherName,
                MotherName = MotherName,
                DOB = DOB,
                State = State,
                Age = Age
            };
            var employeeFullDetails = PostDeleteCall(emp);
            if (employeeFullDetails.Result.StatusCode != System.Net.HttpStatusCode.Created)
            {
                string empdel = ConfigurationManager.AppSettings["EmpDelete"];
                MessageBox.Show(empdel);
                Clear();
            }
            else
            {
                string empnodel = ConfigurationManager.AppSettings["EmpNodelete"];
                MessageBox.Show(empnodel);
            }
            GetEmployeeFullDetails();
        }
        private void DeleteEmployeeDetails()
        {
            string con = ConfigurationManager.AppSettings["EmpConform"];
            string com = ConfigurationManager.AppSettings["EmpConformDel"];
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show(con, com, System.Windows.MessageBoxButton.YesNo, System.Windows.MessageBoxImage.Question);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                ConformDelete();
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
                    var response = client.PostAsync("api/employee/DeleteEmployeeDetails", stringContent);
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
