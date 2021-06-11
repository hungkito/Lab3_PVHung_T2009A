using System;

namespace Part4_ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Employee testEmployee = new Employee("Phung", "Hung", "Lao Cai", 10, 10000000);
            Console.WriteLine(testEmployee.ToString());
            Console.WriteLine(testEmployee.calculateTheBonus(2));
        }
    }
}