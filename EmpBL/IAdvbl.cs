using EmpDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpBL
{
    public interface IAdvbl
    {
        List<DTO> GetEmployeeDetails();
        List<DepDTO> GetDepartmentDetails();
    }
}
