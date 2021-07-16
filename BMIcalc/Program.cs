using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bmiCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Tom", 'H', 152.5, 5, 6);

            Console.WriteLine($"{ p.firstName} : {p.calculateBMI()}");

            Person a = new Person("Leslie", "Knope", 'K', 32, 122.9, 4, 1);

            Console.WriteLine($"{ a.firstName} : {a.calculateBMI()}");

            Person s = new Person("Ron", "Swanson", 222.2, 6, 0);

            Console.WriteLine($"{ s.firstName} : {s.calculateBMI()}");

            Person d = new Person("April", "Ludgate", 110.5, 5, 5);

            Console.WriteLine($"{ d.firstName} : {d.calculateBMI()}");
        }
    }
}
