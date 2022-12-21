using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;

namespace VakantiePlannerModules
{
    public class Employee
    {
        // Properties
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public int OfficeId { get; private set; }
        public int DepartmentId { get; private set; }
        public int VacationDays { get; private set; }
        public Holiday Holiday { get; private set; }

        // Constructors
        public Employee(int id, string name, string email, int departmentId, int officeId)
        {
            Id = id;
            Name = name;
            Email = email;
            DepartmentId = departmentId;
            OfficeId = officeId;
        }

        public Employee(string name, string email, int departmentId, int officeId)
        {
            Name = name;
            Email = email;
            DepartmentId = departmentId;
            OfficeId = officeId;
        }

        //  Methods
        public void GetOffice()
        {
            throw new System.NotImplementedException();
        }

        public void SetOffice()
        {
            throw new System.NotImplementedException();
        }

        public void SetDepartment()
        {
            throw new System.NotImplementedException();
        }

        public void GetDepartment()
        {
            throw new System.NotImplementedException();
        }
    }
}
