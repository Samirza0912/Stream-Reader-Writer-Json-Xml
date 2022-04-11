using System;
using System.IO;
using Newtonsoft.Json;
using Stream_Reader_Writer_Json_Xml.Models;

namespace Stream_Reader_Writer_Json_Xml
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"MacBook - Air - Samir:~samiramiraslanov$\database.json";
            if (!File.Exists(@"MacBook - Air - Samir:~samiramiraslanov$\file"))
            {
                File.Create(@"MacBook - Air - Samir:~samiramiraslanov$\database.json");

            }



            Check();
            Department department = new Department("Samir");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {

                case 1:
                    Employee employee = new Employee("Bukayo", 140000);
                    department.AddEmployee(employee);
                    break;
                case 2:
                    string result;
                    using(StreamReader reader=new StreamReader(path))
                    {
                        result = reader.ReadToEnd();
                    }
                    department  = JsonConvert.DeserializeObject<Department>(result);
                    Console.WriteLine("enter the id");
                    int id = int.Parse(Console.ReadLine());
                    department.GetEmployeeById(id);
                    break;
                case 3:

                    break;
                case 4:
                    break;

            }
            


        }
        public static void Check()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1.Share Status \n" +
                "2.Get All Statuses \n" +
                "3.Get Status by Id \n" +
                "4.Filter Status by ID \n" +
                "0.end program");
            Console.WriteLine("input your choice: ");
        }
    }
}
