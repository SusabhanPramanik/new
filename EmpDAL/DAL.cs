using EmpDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpDAL
{
    public class DAL
    {

        SqlConnection conObj;
        SqlCommand cmdObj;
        EmployeeDetailsEntities contxtObj;
        public DAL()
        {
            conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeConnectionString"].ConnectionString);
            cmdObj = new SqlCommand();
            contxtObj = new EmployeeDetailsEntities();
        }
        public List<DTO> FetchEmployeeDetails()
        {
            try
            {
                var result = (from Emp in contxtObj.tblEmployeeInfoes
                              join Dept in contxtObj.tblEmployeeDetails on Emp.EmployeeID equals Dept.EmployeeID
                              select new { Emp.EmployeeID, Emp.EmployeeName, Dept.Address1, Dept.Address2, Emp.PhoneNumber, Emp.FatherName, Emp.MotherName, Dept.DOB, Dept.State, Dept.Age, Emp.CreatedDate, Emp.UpdatedDate, Emp.IsDeleted }).ToList();

                List<DTO> lstOfEmpDetails = new List<DTO>();
                foreach (var employeeResult in result)
                {
                    lstOfEmpDetails.Add(new DTO()
                    {
                        EmployeeID = Convert.ToInt32(employeeResult.EmployeeID),
                        EmployeeName = employeeResult.EmployeeName,
                        Address1 = employeeResult.Address1,
                        Address2 = employeeResult.Address2,
                        PhoneNumber = Convert.ToInt32(employeeResult.PhoneNumber),
                        FatherName = employeeResult.FatherName,
                        MotherName = employeeResult.MotherName,
                        DOB = Convert.ToDateTime(employeeResult.DOB),
                        State = employeeResult.State,
                        Age = Convert.ToInt32(employeeResult.Age),
                        CreatedDate = employeeResult.CreatedDate,
                        UpdatedDate = employeeResult.UpdatedDate,
                        IsDeleted = employeeResult.IsDeleted
                    });

                }
                return lstOfEmpDetails;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int AddEmployee(DTO newemployee)
        {
            try
            {
                cmdObj = new SqlCommand();
                cmdObj.CommandText = @"uspAddEmployee";
                cmdObj.CommandType = System.Data.CommandType.StoredProcedure;
                cmdObj.Connection = conObj;
                cmdObj.Parameters.AddWithValue(@"EmployeeID", newemployee.EmployeeID);

                cmdObj.Parameters.AddWithValue(@"EmployeeName", newemployee.EmployeeName);
                cmdObj.Parameters.AddWithValue(@"Address1", newemployee.Address1);
                cmdObj.Parameters.AddWithValue(@"Address2", newemployee.Address2);
                cmdObj.Parameters.AddWithValue(@"PhoneNumber", newemployee.PhoneNumber);
                cmdObj.Parameters.AddWithValue(@"FatherName", newemployee.FatherName);
                cmdObj.Parameters.AddWithValue(@"MotherName", newemployee.MotherName);
                cmdObj.Parameters.AddWithValue(@"DOB", newemployee.DOB);
                cmdObj.Parameters.AddWithValue(@"State", newemployee.State);
                cmdObj.Parameters.AddWithValue(@"Age", newemployee.Age);
                SqlParameter retObj = new SqlParameter();
                retObj.Direction = ParameterDirection.ReturnValue;
                retObj.SqlDbType = SqlDbType.Int;
                cmdObj.Parameters.Add(retObj);
                conObj.Open();
                cmdObj.ExecuteNonQuery();
                return Convert.ToInt32(retObj.Value);

            }
            catch (Exception)
            {

                throw;
            }
        }
        public int UpdateEmployee(DTO employee)
        {
            try
            {
                cmdObj = new SqlCommand();
                cmdObj.CommandText = @"uspUpdateEmployee";
                cmdObj.CommandType = System.Data.CommandType.StoredProcedure;
                cmdObj.Connection = conObj;
                cmdObj.Parameters.AddWithValue(@"EmployeeID", employee.EmployeeID);
                cmdObj.Parameters.AddWithValue(@"EmployeeName", employee.EmployeeName);
                cmdObj.Parameters.AddWithValue(@"Address1", employee.Address1);
                cmdObj.Parameters.AddWithValue(@"Address2", employee.Address2);
                cmdObj.Parameters.AddWithValue(@"PhoneNumber", employee.PhoneNumber);
                cmdObj.Parameters.AddWithValue(@"FatherName", employee.FatherName);
                cmdObj.Parameters.AddWithValue(@"MotherName", employee.MotherName);
                cmdObj.Parameters.AddWithValue(@"DOB", employee.DOB);
                cmdObj.Parameters.AddWithValue(@"State", employee.State);
                cmdObj.Parameters.AddWithValue(@"Age", employee.Age);
                SqlParameter retObj = new SqlParameter();
                retObj.Direction = ParameterDirection.ReturnValue;
                retObj.SqlDbType = SqlDbType.Int;
                cmdObj.Parameters.Add(retObj);
                conObj.Open();
                cmdObj.ExecuteNonQuery();
                return Convert.ToInt32(retObj.Value);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int DeleteEmployee(DTO emp)
        {
            try
            {
                cmdObj = new SqlCommand();
                cmdObj.CommandText = @"uspDeleteEmployee";
                cmdObj.CommandType = System.Data.CommandType.StoredProcedure;
                cmdObj.Connection = conObj;
                cmdObj.Parameters.AddWithValue(@"EmployeeID", emp.EmployeeID);

                cmdObj.Parameters.AddWithValue(@"EmployeeName", emp.EmployeeName);
                cmdObj.Parameters.AddWithValue(@"Address1", emp.Address1);
                cmdObj.Parameters.AddWithValue(@"Address2", emp.Address2);
                cmdObj.Parameters.AddWithValue(@"PhoneNumber", emp.PhoneNumber);
                cmdObj.Parameters.AddWithValue(@"FatherName", emp.FatherName);
                cmdObj.Parameters.AddWithValue(@"MotherName", emp.MotherName);
                cmdObj.Parameters.AddWithValue(@"DOB", emp.DOB);
                cmdObj.Parameters.AddWithValue(@"State", emp.State);
                cmdObj.Parameters.AddWithValue(@"Age", emp.Age);
                SqlParameter retObj = new SqlParameter();
                retObj.Direction = ParameterDirection.ReturnValue;
                retObj.SqlDbType = SqlDbType.Int;
                cmdObj.Parameters.Add(retObj);
                conObj.Open();
                cmdObj.ExecuteNonQuery();
                return Convert.ToInt32(retObj.Value);
            }
            catch (Exception)
            {

                throw;
            }
        }


        public List<DepDTO> FetchDepartmentDetails()
        {
            try
            {
                var result = contxtObj.tblDepartments.SqlQuery("SELECT * FROM dbo.tblDepartment").ToList();

                List<DepDTO> lstOfDeptDetails = new List<DepDTO>();
                foreach (var departmentResult in result)
                {
                    lstOfDeptDetails.Add(new DepDTO()
                    {
                        EmployeeID = Convert.ToInt32(departmentResult.EmployeeID),
                        DepartmentID = Convert.ToInt32(departmentResult.DepartmentID),
                        DepartmentName = departmentResult.DepartmentName,
                        CreatedDate = departmentResult.CreatedDate,
                        UpdatedDate = departmentResult.UpdatedDate,
                        IsDeleted = departmentResult.IsDeleted
                    });

                }
                return lstOfDeptDetails;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public int AddDepartment(DepDTO newdepartment)
        {
            try
            {
                cmdObj = new SqlCommand();
                cmdObj.CommandText = @"uspAddDepartment";
                cmdObj.CommandType = System.Data.CommandType.StoredProcedure;
                cmdObj.Connection = conObj;
                cmdObj.Parameters.AddWithValue(@"EmployeeID", newdepartment.EmployeeID);
                cmdObj.Parameters.AddWithValue(@"DepartmentID", newdepartment.DepartmentID);
                cmdObj.Parameters.AddWithValue(@"DepartmentName", newdepartment.DepartmentName);
                SqlParameter retObj = new SqlParameter();
                retObj.Direction = ParameterDirection.ReturnValue;
                retObj.SqlDbType = SqlDbType.Int;
                cmdObj.Parameters.Add(retObj);
                conObj.Open();
                cmdObj.ExecuteNonQuery();
                return Convert.ToInt32(retObj.Value);

            }
            catch (Exception)
            {

                throw;
            }
        }
        public int UpdateDepartment(DepDTO department)
        {
            try
            {
                cmdObj = new SqlCommand();
                cmdObj.CommandText = @"uspUpdateDepartment";
                cmdObj.CommandType = System.Data.CommandType.StoredProcedure;
                cmdObj.Connection = conObj;
                cmdObj.Parameters.AddWithValue(@"EmployeeID", department.EmployeeID);
                cmdObj.Parameters.AddWithValue(@"DepartmentID", department.DepartmentID);
                cmdObj.Parameters.AddWithValue(@"DepartmentName", department.DepartmentName);
                SqlParameter retObj = new SqlParameter();
                retObj.Direction = ParameterDirection.ReturnValue;
                retObj.SqlDbType = SqlDbType.Int;
                cmdObj.Parameters.Add(retObj);
                conObj.Open();
                cmdObj.ExecuteNonQuery();
                return Convert.ToInt32(retObj.Value);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int DeleteDepartment(DepDTO dep)
        {
            try
            {
                cmdObj = new SqlCommand();
                cmdObj.CommandText = @"uspDeleteDepartment";
                cmdObj.CommandType = System.Data.CommandType.StoredProcedure;
                cmdObj.Connection = conObj;
                cmdObj.Parameters.AddWithValue(@"EmployeeID", dep.EmployeeID);
                cmdObj.Parameters.AddWithValue(@"DepartmentID", dep.DepartmentID);
                cmdObj.Parameters.AddWithValue(@"DepartmentName", dep.DepartmentName);
                SqlParameter retObj = new SqlParameter();
                retObj.Direction = ParameterDirection.ReturnValue;
                retObj.SqlDbType = SqlDbType.Int;
                cmdObj.Parameters.Add(retObj);
                conObj.Open();
                cmdObj.ExecuteNonQuery();
                return Convert.ToInt32(retObj.Value);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
