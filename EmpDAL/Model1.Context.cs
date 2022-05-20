﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmpDAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EmployeeDetailsEntities : DbContext
    {
        public EmployeeDetailsEntities()
            : base("name=EmployeeDetailsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tblDepartment> tblDepartments { get; set; }
        public virtual DbSet<tblEmployeeDetail> tblEmployeeDetails { get; set; }
        public virtual DbSet<tblEmployeeInfo> tblEmployeeInfoes { get; set; }
        public virtual DbSet<tblEmployeeDepart> tblEmployeeDeparts { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int uspAddEmployee(Nullable<int> employeeID, string employeeName, string address1, string address2, Nullable<int> phoneNumber, string fatherName, string motherName, Nullable<System.DateTime> dOB, string state, Nullable<int> age, string isDeleted)
        {
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("EmployeeID", employeeID) :
                new ObjectParameter("EmployeeID", typeof(int));
    
            var employeeNameParameter = employeeName != null ?
                new ObjectParameter("EmployeeName", employeeName) :
                new ObjectParameter("EmployeeName", typeof(string));
    
            var address1Parameter = address1 != null ?
                new ObjectParameter("Address1", address1) :
                new ObjectParameter("Address1", typeof(string));
    
            var address2Parameter = address2 != null ?
                new ObjectParameter("Address2", address2) :
                new ObjectParameter("Address2", typeof(string));
    
            var phoneNumberParameter = phoneNumber.HasValue ?
                new ObjectParameter("PhoneNumber", phoneNumber) :
                new ObjectParameter("PhoneNumber", typeof(int));
    
            var fatherNameParameter = fatherName != null ?
                new ObjectParameter("FatherName", fatherName) :
                new ObjectParameter("FatherName", typeof(string));
    
            var motherNameParameter = motherName != null ?
                new ObjectParameter("MotherName", motherName) :
                new ObjectParameter("MotherName", typeof(string));
    
            var dOBParameter = dOB.HasValue ?
                new ObjectParameter("DOB", dOB) :
                new ObjectParameter("DOB", typeof(System.DateTime));
    
            var stateParameter = state != null ?
                new ObjectParameter("state", state) :
                new ObjectParameter("state", typeof(string));
    
            var ageParameter = age.HasValue ?
                new ObjectParameter("Age", age) :
                new ObjectParameter("Age", typeof(int));
    
            var isDeletedParameter = isDeleted != null ?
                new ObjectParameter("IsDeleted", isDeleted) :
                new ObjectParameter("IsDeleted", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspAddEmployee", employeeIDParameter, employeeNameParameter, address1Parameter, address2Parameter, phoneNumberParameter, fatherNameParameter, motherNameParameter, dOBParameter, stateParameter, ageParameter, isDeletedParameter);
        }
    
        public virtual int uspDeleteEmployee(Nullable<int> employeeID, string employeeName, string address1, string address2, Nullable<int> phoneNumber, string fatherName, string motherName, Nullable<System.DateTime> dOB, string state, Nullable<int> age, string isDeleted)
        {
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("EmployeeID", employeeID) :
                new ObjectParameter("EmployeeID", typeof(int));
    
            var employeeNameParameter = employeeName != null ?
                new ObjectParameter("EmployeeName", employeeName) :
                new ObjectParameter("EmployeeName", typeof(string));
    
            var address1Parameter = address1 != null ?
                new ObjectParameter("Address1", address1) :
                new ObjectParameter("Address1", typeof(string));
    
            var address2Parameter = address2 != null ?
                new ObjectParameter("Address2", address2) :
                new ObjectParameter("Address2", typeof(string));
    
            var phoneNumberParameter = phoneNumber.HasValue ?
                new ObjectParameter("PhoneNumber", phoneNumber) :
                new ObjectParameter("PhoneNumber", typeof(int));
    
            var fatherNameParameter = fatherName != null ?
                new ObjectParameter("FatherName", fatherName) :
                new ObjectParameter("FatherName", typeof(string));
    
            var motherNameParameter = motherName != null ?
                new ObjectParameter("MotherName", motherName) :
                new ObjectParameter("MotherName", typeof(string));
    
            var dOBParameter = dOB.HasValue ?
                new ObjectParameter("DOB", dOB) :
                new ObjectParameter("DOB", typeof(System.DateTime));
    
            var stateParameter = state != null ?
                new ObjectParameter("state", state) :
                new ObjectParameter("state", typeof(string));
    
            var ageParameter = age.HasValue ?
                new ObjectParameter("Age", age) :
                new ObjectParameter("Age", typeof(int));
    
            var isDeletedParameter = isDeleted != null ?
                new ObjectParameter("IsDeleted", isDeleted) :
                new ObjectParameter("IsDeleted", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspDeleteEmployee", employeeIDParameter, employeeNameParameter, address1Parameter, address2Parameter, phoneNumberParameter, fatherNameParameter, motherNameParameter, dOBParameter, stateParameter, ageParameter, isDeletedParameter);
        }
    
        public virtual int uspUpdateEmployee(Nullable<int> employeeID, string employeeName, string address1, string address2, Nullable<int> phoneNumber, string fatherName, string motherName, Nullable<System.DateTime> dOB, string state, Nullable<int> age, string isDeleted)
        {
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("EmployeeID", employeeID) :
                new ObjectParameter("EmployeeID", typeof(int));
    
            var employeeNameParameter = employeeName != null ?
                new ObjectParameter("EmployeeName", employeeName) :
                new ObjectParameter("EmployeeName", typeof(string));
    
            var address1Parameter = address1 != null ?
                new ObjectParameter("Address1", address1) :
                new ObjectParameter("Address1", typeof(string));
    
            var address2Parameter = address2 != null ?
                new ObjectParameter("Address2", address2) :
                new ObjectParameter("Address2", typeof(string));
    
            var phoneNumberParameter = phoneNumber.HasValue ?
                new ObjectParameter("PhoneNumber", phoneNumber) :
                new ObjectParameter("PhoneNumber", typeof(int));
    
            var fatherNameParameter = fatherName != null ?
                new ObjectParameter("FatherName", fatherName) :
                new ObjectParameter("FatherName", typeof(string));
    
            var motherNameParameter = motherName != null ?
                new ObjectParameter("MotherName", motherName) :
                new ObjectParameter("MotherName", typeof(string));
    
            var dOBParameter = dOB.HasValue ?
                new ObjectParameter("DOB", dOB) :
                new ObjectParameter("DOB", typeof(System.DateTime));
    
            var stateParameter = state != null ?
                new ObjectParameter("state", state) :
                new ObjectParameter("state", typeof(string));
    
            var ageParameter = age.HasValue ?
                new ObjectParameter("Age", age) :
                new ObjectParameter("Age", typeof(int));
    
            var isDeletedParameter = isDeleted != null ?
                new ObjectParameter("IsDeleted", isDeleted) :
                new ObjectParameter("IsDeleted", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspUpdateEmployee", employeeIDParameter, employeeNameParameter, address1Parameter, address2Parameter, phoneNumberParameter, fatherNameParameter, motherNameParameter, dOBParameter, stateParameter, ageParameter, isDeletedParameter);
        }
    
        public virtual int uspAddDepartment(Nullable<int> employeeID, Nullable<int> departmentID, string departmentName, string isDeleted)
        {
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("EmployeeID", employeeID) :
                new ObjectParameter("EmployeeID", typeof(int));
    
            var departmentIDParameter = departmentID.HasValue ?
                new ObjectParameter("DepartmentID", departmentID) :
                new ObjectParameter("DepartmentID", typeof(int));
    
            var departmentNameParameter = departmentName != null ?
                new ObjectParameter("DepartmentName", departmentName) :
                new ObjectParameter("DepartmentName", typeof(string));
    
            var isDeletedParameter = isDeleted != null ?
                new ObjectParameter("IsDeleted", isDeleted) :
                new ObjectParameter("IsDeleted", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspAddDepartment", employeeIDParameter, departmentIDParameter, departmentNameParameter, isDeletedParameter);
        }
    
        public virtual int uspDeleteDepartment(Nullable<int> employeeID, Nullable<int> departmentID, string departmentName, string isDeleted)
        {
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("EmployeeID", employeeID) :
                new ObjectParameter("EmployeeID", typeof(int));
    
            var departmentIDParameter = departmentID.HasValue ?
                new ObjectParameter("DepartmentID", departmentID) :
                new ObjectParameter("DepartmentID", typeof(int));
    
            var departmentNameParameter = departmentName != null ?
                new ObjectParameter("DepartmentName", departmentName) :
                new ObjectParameter("DepartmentName", typeof(string));
    
            var isDeletedParameter = isDeleted != null ?
                new ObjectParameter("IsDeleted", isDeleted) :
                new ObjectParameter("IsDeleted", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspDeleteDepartment", employeeIDParameter, departmentIDParameter, departmentNameParameter, isDeletedParameter);
        }
    
        public virtual int uspUpdateDepartment(Nullable<int> employeeID, Nullable<int> departmentID, string departmentName, string isDeleted)
        {
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("EmployeeID", employeeID) :
                new ObjectParameter("EmployeeID", typeof(int));
    
            var departmentIDParameter = departmentID.HasValue ?
                new ObjectParameter("DepartmentID", departmentID) :
                new ObjectParameter("DepartmentID", typeof(int));
    
            var departmentNameParameter = departmentName != null ?
                new ObjectParameter("DepartmentName", departmentName) :
                new ObjectParameter("DepartmentName", typeof(string));
    
            var isDeletedParameter = isDeleted != null ?
                new ObjectParameter("IsDeleted", isDeleted) :
                new ObjectParameter("IsDeleted", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspUpdateDepartment", employeeIDParameter, departmentIDParameter, departmentNameParameter, isDeletedParameter);
        }
    }
}