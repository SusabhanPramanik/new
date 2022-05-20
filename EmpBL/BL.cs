using EmpDAL;
using EmpDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpBL
{
    public class BL : IAdvbl
    {
        DAL dlObj;

        public BL()
        {
            dlObj = new DAL();
        }
        public List<DTO> GetEmployeeDetails()
        {
            try
            {
                List<DTO> lstFromDl = dlObj.FetchEmployeeDetails();
                return lstFromDl;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int DisplayAllEmployee(DTO newemployee)
        {
            return dlObj.AddEmployee(newemployee);
        }
        public int UpdateAllEmployee(DTO employee)
        {
            return dlObj.UpdateEmployee(employee);
        }
        public int DeleteAllEmployee(DTO emp)
        {
            return dlObj.DeleteEmployee(emp);
        }

        public List<DepDTO> GetDepartmentDetails()
        {
            try
            {
                List<DepDTO> lstFromDl = dlObj.FetchDepartmentDetails();
                return lstFromDl;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int CreateAllDepartment(DepDTO newdepartment)
        {
            return dlObj.AddDepartment(newdepartment);
        }
        public int UpdateAllDepartment(DepDTO department)
        {
            return dlObj.UpdateDepartment(department);
        }
        public int DeleteAllDepartment(DepDTO dep)
        {
            return dlObj.DeleteDepartment(dep);
        }

    }
}
