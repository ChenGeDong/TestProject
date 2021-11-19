using System;
using static System.Console;
namespace BubbleSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees =
            {
                    new Employee("Bugs Bunny",20000),
                    new Employee("Elmer Fudd", 10000),
                    new Employee("Daffy Duck",25000),
                    new Employee("Wile Coyote",1000000.38m),
                    new Employee("Foghorn Leghorn",23000),
                    new Employee("RoadRunner",50000)
                    
            };

            BubbleSorter.Sort(employees,Employee.CompareSalary);
            foreach (var employee in employees)
            {
                WriteLine(employee);
            }
            //Console.WriteLine("Hello World!");
        }
        
    }
}
