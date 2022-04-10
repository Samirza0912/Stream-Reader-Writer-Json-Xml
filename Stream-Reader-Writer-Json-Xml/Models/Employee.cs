using System;
namespace Stream_Reader_Writer_Json_Xml.Models
{
    public class Employee
    {
        /*Employee class
 - Id
 - Name
 - Salary
 - ShowInfo()
 */
        private static int _Id;
        public int ID { get; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public bool IsDeleted { get; set; }

        public Employee(string name, double salary)
        {
            _Id++;
            _Id = ID;
            Name = name;
            Salary = salary;
            IsDeleted = false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID: {ID} \n Name: {Name} \n Salary: {Salary}");
        }
    }
}
