using System;

namespace DepartmentDetails
{
    class Program
    {
        static void Main(string[] args)
        {

            Department hr = new Department(005, "HR department");
            Department account = new Department(005, "account department");

            Manager manager = new Manager();
            manager._employeeID = 101;
            manager._employeeName = "Jane";
            manager._employeeDepartment = hr;

            Executive executive = new Executive();
            executive._employeeID = 102;
            executive._employeeName = "John";
            executive._employeeDepartment = account;
           

            Employee intern = new Employee();
            intern._employeeID = 103;
            intern._employeeName = "Jack";
            

            Console.WriteLine(manager.SayName());
            Console.WriteLine(manager._employeeDepartment.GetDepartmentDetails());
            Console.WriteLine(manager.DoWork());
            Console.WriteLine(manager._isManager);


            Console.WriteLine(executive.SayName());
            Console.WriteLine(executive._employeeDepartment.GetDepartmentDetails());
            Console.WriteLine(executive.DoWork());
            Console.WriteLine(executive._isExecutive);



            Console.WriteLine(intern.SayName());
            //Console.WriteLine(intern._employeeDepartment.GetDepartmentDetails());
            Console.WriteLine(intern.DoWork());
            Console.ReadKey();

        }
    }
}
