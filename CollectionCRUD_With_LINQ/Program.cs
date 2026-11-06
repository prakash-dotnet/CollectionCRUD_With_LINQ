using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionCRUD_With_LINQ
{
    //Working with Collections and LINQ 
    // CRUD operations using LINQ Methods

    //creating an Entity class 
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }

    internal class Program
    {
        //creating a collection of Employee objects
       static List<Employee> employees = new List<Employee>()
        {
            new Employee(){Id=1, Name="John", Salary=50000},
            new Employee(){Id=2, Name="Ram", Salary=60000},
            new Employee(){Id=3, Name="Bob", Salary=70000},
            new Employee(){Id=4, Name="Krish", Salary=80000},
            new Employee(){Id=5, Name="Tom", Salary=90000}
        };

        static void ShowAllEmployees()
        {
            Console.WriteLine("All Employees:");
            foreach (var emp in employees)
            {
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary}");
            }
        }
        static void AddEmployee(Employee emp)
        {
            employees.Add(emp);
            Console.WriteLine($"Employee {emp.Name} added successfully.");
        }   
                
        static void UpdateEmployee(int id, int newSalary)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);
            if (emp != null)
            { 
                emp.Salary = newSalary;
                Console.WriteLine($"Employee {id} updated successfully.");
            }
            else
            {
                Console.WriteLine($"Employee {id} not found.");
            }
        }   

        static void Main(string[] args)
        {
            Employee emp1=new Employee() { Id = 6, Name = "Alice", Salary = 100000 };
            // AddEmployee(emp1);
            Console.WriteLine("Before Updating");
            ShowAllEmployees();
            //updating salary of an employee
            UpdateEmployee(3, 75000);
            Console.WriteLine("After Updating Salary of Bob..");
            ShowAllEmployees();
            Console.ReadKey();
            //Task#1. Create a Method called DeleteEmployeeById()
            //Task#2. Convert this program as Menu Driven using while and switch

        }
    }
}
