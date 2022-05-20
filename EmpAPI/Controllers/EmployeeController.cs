using EmpBL;
using EmpDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmpAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        BL blObj;
        IAdvbl iblobj;

        public EmployeeController() : this(new BL())
        {

        }
        public EmployeeController(IAdvbl iadvobj)
        {
            // blObj = new BL();
            iblobj = iadvobj;
        }
        [HttpGet]
        public HttpResponseMessage GetEmployeeFullDetails()
        {
            try
            {
                // var result = blObj.GetEmployeeDetails();
                var result = iblobj.GetEmployeeDetails();
                if (result.Count > 0)
                {
                    return Request.CreateResponse(HttpStatusCode.Created, result);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "No Employee Details Found");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public HttpResponseMessage Display(DTO newemployee)
        {
            try
            {
                int res = blObj.DisplayAllEmployee(newemployee);
                if (res == 0)
                {
                    return Request.CreateResponse(HttpStatusCode.Created, newemployee);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Something went wrong");
                }
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.OK, ex.Message);
            }

        }
        [HttpPost]
        public HttpResponseMessage UpdateEmployeeDetails(DTO employee)
        {
            try
            {
                int res = blObj.UpdateAllEmployee(employee);
                if (res == 1)
                {
                    return Request.CreateResponse(HttpStatusCode.Created, employee);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Something went wrong");
                }
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.OK, ex.Message);
            }

        }
        [HttpPost]
        public HttpResponseMessage DeleteEmployeeDetails(DTO emp)
        {
            try
            {
                int res = blObj.DeleteAllEmployee(emp);
                if (res == 1)
                {
                    return Request.CreateResponse(HttpStatusCode.Created, emp);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Something went wrong");
                }
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.OK, ex.Message);
            }

        }

        [HttpGet]
        public HttpResponseMessage GetDepartmentFullDetails()
        {
            try
            {
                var result = iblobj.GetDepartmentDetails();
                if (result.Count > 0)
                {
                    return Request.CreateResponse(HttpStatusCode.Created, result);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "No Employee Details Found");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public HttpResponseMessage CreateDepartment(DepDTO newdepartment)
        {
            try
            {
                int res = blObj.CreateAllDepartment(newdepartment);
                if (res == 0)
                {
                    return Request.CreateResponse(HttpStatusCode.Created, newdepartment);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Something went wrong");
                }
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.OK, ex.Message);
            }

        }
        [HttpPost]
        public HttpResponseMessage UpdateDepartmentDetails(DepDTO department)
        {
            try
            {
                int res = blObj.UpdateAllDepartment(department);
                if (res == 1)
                {
                    return Request.CreateResponse(HttpStatusCode.Created, department);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Something went wrong");
                }
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.OK, ex.Message);
            }

        }
        [HttpPost]
        public HttpResponseMessage DeleteDepartmentDetails(DepDTO dep)
        {
            try
            {
                int res = blObj.DeleteAllDepartment(dep);
                if (res == 1)
                {
                    return Request.CreateResponse(HttpStatusCode.Created, dep);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Something went wrong");
                }
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.OK, ex.Message);
            }

        }
    }
}