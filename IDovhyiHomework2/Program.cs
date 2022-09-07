﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace IDovhyiHomework2
{
    internal class Program
    {
        enum HTTPError
        {
            error400,
            error401,
            error402,
            error403,
            error404,
            other
        }
        struct Dog
        {
            public string name;
            public string mark;
            public int age;
            public override string ToString()
            {
                return string.Format("Dog => Name: {0}, Mark: {1}, Age {2}", name, mark,age);
            }
        }
        static void Main(string[] args)
        {
        // Task 1
        // Read 3 float numbers and check if they are all in the range[-5.5].

        Console.WriteLine("Task 1");
            Console.Write("Enter fist number ");
            float firstNumer = float.Parse(Console.ReadLine());
            Console.Write("Enter second number ");
            float secondNumer = float.Parse(Console.ReadLine());
            Console.Write("Enter third number ");
            float thirdNumer = float.Parse(Console.ReadLine());
            if ((firstNumer <= 5) &&
                (firstNumer >= -5) &&
                (secondNumer <= 5) &&
                (secondNumer >= -5) &&
                (thirdNumer <= 5) &&
                (thirdNumer >= -5)) { Console.WriteLine("All 3 numbers are in the range [-5,5]"); }
            else
            {
                Console.WriteLine("Not all numbers are in the range [-5,5]");
                if ((firstNumer <= 5) && (firstNumer >= -5)) { Console.WriteLine("Fist number {0} is in the range [-5.5]", firstNumer); }
                if ((secondNumer <= 5) && (secondNumer >= -5)) { Console.WriteLine("Second number {0} is in the range [-5.5]", secondNumer); }
                if ((thirdNumer <= 5) && (thirdNumer >= -5)) { Console.WriteLine("Third number {0} is in the range [-5.5]", thirdNumer); }
            }
            Console.ReadKey();

            // Task 2
            // Read 3 integer numbers and output max and min of them.

            Console.WriteLine("Task 2");
            Console.Write("Enter first integer number ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second integer number ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter third integer number ");
            int c = int.Parse(Console.ReadLine());
            int max = (a >= b) ? ((a >= c) ? a : c) : ((b >= c) ? b : c);
            int min = (a <= b) ? ((a <= c) ? a : c) : ((b <= c) ? b : c);
            Console.WriteLine("Max numer: {0} ", max);
            Console.WriteLine("Min numer: {0} ", min);
            Console.ReadKey();

            // Task 3
            // Read number of HTTP Error(400, 401, 402, ...) and write the name of this error

            Console.WriteLine("Task 3");
            Console.Write("Enter number of HTTP Error(400, 401, 402, ...) ");
            int httpError = int.Parse(Console.ReadLine());
            HTTPError httpErrorPrint;

            switch (httpError) {
                case 400:
                    httpErrorPrint = HTTPError.error400;
                    break;
                case 401:
                    httpErrorPrint = HTTPError.error401;
                    break;
                case 402:
                    httpErrorPrint = HTTPError.error402;
                    break;
                case 403:
                    httpErrorPrint = HTTPError.error403;
                    break;
                case 404:
                    httpErrorPrint = HTTPError.error404;
                    break;
                default:
                    httpErrorPrint = HTTPError.other;
                    break;
            }
            Console.Write("Error: ");
            switch (httpErrorPrint)
            {
                case HTTPError.error400:
                    Console.WriteLine("Unauthorized");
                    break;
                case HTTPError.error401:
                    Console.WriteLine("Unauthorized");
                    break;
                case HTTPError.error402:
                    Console.WriteLine("Payment Required");
                    break;
                case HTTPError.error403:
                    Console.WriteLine("Forbidden");
                    break;
                case HTTPError.error404:
                    Console.WriteLine("Not Found");
                    break;
                default:
                    Console.WriteLine("I don't know what kind of error it is");
                    break;
            }
            Console.ReadKey();

            // Task 4
            // Declare struct Dog with fields name, mark, age.
            // Declare object myDog of Dog type and read values for it.
            // Output information on the console. (Override method ToString in struct)
            
            Console.WriteLine("Task 4");
            Dog myDog;
            Console.Write("Enter dog's name: ");
            myDog.name = Console.ReadLine();
            Console.Write("Enter dog's mark: ");
            myDog.mark = Console.ReadLine();
            Console.Write("Enter dog's age: ");
            myDog.age = int.Parse(Console.ReadLine());
            Console.WriteLine(myDog);
            Console.ReadKey();
        }
    }
}
