using System;   
namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Asmaa", 25, 20000);
            Employee e2 = new Employee("Abdallah", 32, 30000);
            Manager m1 = new Manager("Ahmed", 30, 40000, 10000);

            e1.Salary = -10000m;
            Console.WriteLine("****************************************");
            e1.DisplayInfo();
            Console.WriteLine("****************************************");
            e2.DisplayInfo();
            Console.WriteLine("****************************************");
            m1.DisplayInfo();
            

            
        }
    }
}
