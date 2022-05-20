using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmpWPF.Models
{
    public class Employee : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
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
            set { state = value; OnPropertyChanged("String"); }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; OnPropertyChanged("Age"); }
        }

        private DateTime createdDate;
        public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; OnPropertyChanged("CreatedDate"); }
        }

        private DateTime updatedDate;
        public DateTime UpdatedDate
        {
            get { return updatedDate; }
            set { updatedDate = value; OnPropertyChanged("UpdatedDate"); }
        }

        private string isDeleted;
        public string Isdeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; OnPropertyChanged("IsDeleted"); }
        }
    }
    public class Department : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
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
        private DateTime createdDate;
        public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; OnPropertyChanged("CreatedDate"); }
        }

        private DateTime updatedDate;
        public DateTime UpdatedDate
        {
            get { return updatedDate; }
            set { updatedDate = value; OnPropertyChanged("UpdatedDate"); }
        }

        private string isDeleted;
        public string Isdeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; OnPropertyChanged("IsDeleted"); }
        }
    }
}