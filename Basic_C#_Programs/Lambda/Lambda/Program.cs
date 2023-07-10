using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>(); //Creates a list of 10 employee objects, with names and Ids assigned to them all.
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Bob", Id = 1 });
            employees.Add(new Employee() { FirstName = "John", LastName = "Smith", Id = 2 });
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Wing", Id = 3 });
            employees.Add(new Employee() { FirstName = "Tyler", LastName = "Toe", Id = 4 });
            employees.Add(new Employee() { FirstName = "Billy", LastName = "Biden", Id = 5 });
            employees.Add(new Employee() { FirstName = "Williams", LastName = "Cox", Id = 6 });
            employees.Add(new Employee() { FirstName = "Lane", LastName = "Ziegler", Id = 7 });
            employees.Add(new Employee() { FirstName = "Peter", LastName = "Patone", Id = 8 });
            employees.Add(new Employee() { FirstName = "Nate", LastName = "Gallagher", Id = 9 });
            employees.Add(new Employee() { FirstName = "Handsome", LastName = "Bill", Id = 10 });

            //List<Employee> employeesjoe = new List<Employee>(); //creates a new list called employeesjoe, to store the information of all employees name Joe. This block of code is commented out due to it conflicting with the below code if ran at the same time.

            //foreach(Employee employee in employees) //foreach loop that iterates through each employee in the list
            //{
            //    if(employee.FirstName == "Joe") //if statement that runs if the employee's first name is equal to Joe
            //    {
            //        employeesjoe.Add(employee); //Adds the employee that has the name Joe to the list employeesjoe
            //    }
            //}
            //Console.WriteLine(employeesjoe.Count); //Verifies that 2 employees were added to the list employeesjoe

            List<Employee> employeesjoe = employees.Where(x => x.FirstName == "Joe").ToList(); //Lambda expression that adds each employee with the name Joe to a new list called employeesjoe
            List<Employee> employeesId5 = employees.Where(x => x.Id > 5).ToList(); //Lambda expression that adds each employee with an Id greater than 5 to a list named employeesId5



            Console.WriteLine(employeesjoe.Count); //Verifies that the employees with the name joe were added to the list
            Console.WriteLine(employeesId5.Count); //Verifies that the employees with an Id greater than 5 were added to the list
            Console.ReadLine();





        }
    }
}
