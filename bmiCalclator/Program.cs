using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bmiCalclator
{
    //internal class Program
   // {
        //      static void Main(string[] args)
        //  {
        //    Console.WriteLine("              BMI-CALCULATOR");
        //    Console.WriteLine("____________________________________________");
        //    Console.WriteLine("Enter your name  :  ");
        //    string name = Console.ReadLine();
        //    Console.WriteLine("Enter your height (in metrs) : ");
        //    double height = double.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter your weight(in kg) : ");
        //    double weight = double.Parse(Console.ReadLine());
        //    double bmi = weight / (height * height);

        //    Console.WriteLine($"hello {name} ,  your BMI is :  {bmi:F2} " );
        //    Console.ReadLine();
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("BMI Calculator");
        //    Console.WriteLine("--------------");

        //    Console.Write("Enter your name: ");
        //    string name = Console.ReadLine();

        //    Console.Write("Enter your weight (in kilograms): ");
        //    double weight = double.Parse(Console.ReadLine());

        //    Console.Write("Enter your height (in meters): ");
        //    double height = double.Parse(Console.ReadLine());

        //    // Calculate BMI (BMI = weight / height^2)
        //    double bmi = weight / (height * height);

        //    Console.WriteLine($"Hello {name}, your BMI is: {bmi:F2}");
        //    Console.ReadLine()
        //}
    //}
 //   using System;

class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BMI Calculator");
            Console.WriteLine("--------------");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your weight (in kilograms): ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Enter your height (in meters): ");
            double height = double.Parse(Console.ReadLine());

            // Calculate BMI (BMI = weight / height^2)
            double bmi = weight / (height * height);

            Console.WriteLine($"Hello {name}, your BMI is: {bmi:F2}");

            // Interpret BMI
            if (bmi < 18.5)
            {
                Console.WriteLine("You are underweight.");
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                Console.WriteLine("You are within a healthy weight range.");
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                Console.WriteLine("You are overweight.");
            }
            else
            {
                Console.WriteLine("You are obese.");
            }

            Console.ReadLine();
        }
    }

}