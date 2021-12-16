using System;

namespace BasicClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car();
            car1.Make = "Jeep";
            car1.Model = "Cherokee";
            car1.Year = 2002;

            Console.WriteLine($"Car Make:{car1.Make}");
            Console.WriteLine($"Car Model:{car1.Model}");
            Console.WriteLine($"Car Year:{car1.Year}");
        }
    }
}
