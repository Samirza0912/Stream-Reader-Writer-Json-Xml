using System;
using System.Collections.Generic;

namespace Stream_Reader_Writer_Json_Xml.Models
{
    public class Department
    {
        /*Department
- Id
- Name
- Employees list

- AddEmployee() - employee obyekti qebul edecek
- GetEmployeeById() - id qebul edecek
- RemoveEmployee() - id qebul edecek
        */
        private static int _Id;
        public int ID { get; }
        public string Name { get; set; }
        public string EmployeesList { get; set; }
        

        public Department(string name, string employeeslist)
        {
            _Id++;
            _Id = ID;
            Name = name;
            EmployeesList = employeeslist;
            
        }

        List<Employee> employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void GetEmployeeById(int id)
        {
            foreach (var item in employees)
            {
                if (ID == id)
                {
                    item.ShowInfo();
                }
            }
        }

        public void RemoveEmployee(int id)
        {
            foreach (var item in employees)
            {
                if (ID==id && item.IsDeleted == false)
                {
                    item.IsDeleted = true;
                }
            }
        }

    }
}
