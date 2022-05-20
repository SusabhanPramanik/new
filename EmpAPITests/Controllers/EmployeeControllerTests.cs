using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmpAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpDTO;
using Moq;
using EmpBL;
using System.Net.Http;
using System.Web.Http.Hosting;
using System.Web.Http;

namespace EmpAPI.Controllers.Tests
{
    [TestClass()]
    public class EmployeeControllerTests
    {
        [TestMethod()]
        public void GetEmployeeFullDetailsTest()
        {
            DTO expectedresult = new DTO();
            expectedresult.EmployeeID = 40020526;
            expectedresult.EmployeeName = "Harish";
            expectedresult.Address1 = "mmmm";
            expectedresult.Address2 = "nnnn";
            expectedresult.PhoneNumber = 22222;
            expectedresult.FatherName = "eeee";
            expectedresult.MotherName = "dddd";
            expectedresult.State = "Banglore";
            expectedresult.Age = 23;


            List<DTO> result = new List<DTO>();
            result.Add(expectedresult);

            Mock<IAdvbl> mockobj = new Mock<IAdvbl>();
            mockobj.Setup(x => x.GetEmployeeDetails()).Returns(result);

            EmployeeController controlobj = new EmployeeController(mockobj.Object);
            controlobj.Request = new HttpRequestMessage()
            {
                Properties =
                {
                    {
                        HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration()
                    }
                }
            };
            HttpResponseMessage actualresult = controlobj.GetEmployeeFullDetails();

            List<DTO> lstactualobj = actualresult.Content.ReadAsAsync<List<DTO>>().Result;
            Assert.AreEqual(result, lstactualobj);
        }

        [TestMethod()]
        public void GetDepartmentFullDetailsTest()
        {
            DepDTO expectedresult = new DepDTO();
            expectedresult.EmployeeID = 40020526;
            expectedresult.DepartmentID = 50;
            expectedresult.DepartmentName = "Devops";

            List<DepDTO> result = new List<DepDTO>();
            result.Add(expectedresult);

            Mock<IAdvbl> mockobj = new Mock<IAdvbl>();
            mockobj.Setup(x => x.GetDepartmentDetails()).Returns(result);

            EmployeeController controlobj = new EmployeeController(mockobj.Object);
            controlobj.Request = new HttpRequestMessage()
            {
                Properties =
                {
                    {
                        HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration()
                    }
                }
            };
            HttpResponseMessage actualresult = controlobj.GetDepartmentFullDetails();

            List<DepDTO> lstactualobj = actualresult.Content.ReadAsAsync<List<DepDTO>>().Result;
            Assert.AreEqual(result, lstactualobj);
        }
    }
}