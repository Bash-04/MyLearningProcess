﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VakantiePlannerModules
{
    public class Department
    {
        // Properties
        public string Name { get; private set; }
        public int NumberOfEmployees { get; private set; }

        // Constructors
        public Department(string name, int numberOfEmployees)
        {
            Name = name;
            NumberOfEmployees = numberOfEmployees;
        }

        public Department(string name)
        {
            Name = name;
        }

        public Department()
        {

        }

        // Methods
        List<Department> departments = new List<Department>();
        public List<Department> GetAllDepartments()
        {
            Department department = new Department("Alle");
            departments.Add(department);

            return departments;
        }

        public void AddEmployee()
        {
            throw new System.NotImplementedException();
        }

        public void SetOffice()
        {
            throw new System.NotImplementedException();
        }

        public void GetOffice()
        {
            throw new System.NotImplementedException();
        }
    }
}
