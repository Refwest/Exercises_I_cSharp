// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesI;

class Program
{
      static void Main(string[] args)
    {
        //!Exercises I.1 - Calculator that summing.

        Console.WriteLine("Hi, tell me first number that you want to summ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("First number is {0}, tell me second number", firstNumber);
        double secondNumber = double.Parse(Console.ReadLine());
        double result = firstNumber + secondNumber;

        Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, result);


        //!Exercises I.2 - Cost of carpeting rectangle room with cost of carpetig per square meter.

        Console.WriteLine("What is width [m] of your rectangle room?");

        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Width of room is {0}m, what is lenght of room?", width);

        double lenght = double.Parse(Console.ReadLine());
        Console.WriteLine("Width is {0}m, lenght is {1}m, what is cost of carpeting [zł/m2]?", width, lenght);

        double cost = double.Parse(Console.ReadLine());
        double area = width * lenght;
        double price = width * lenght * cost;
        Console.WriteLine("Cost of carpeting {0}m2 room is {1}zł", area, price);

        //!Exercise I.3 - Program changes time in minutes to time in houers

        Console.WriteLine("Hi, please tell how many minutes you want change to hours");
        int minutes = int.Parse(Console.ReadLine());
        int hours = minutes / 60;
        int remainingMinutes = minutes % 60;
        Console.WriteLine("{0} minutes is equal to {1} hours and {2} minutes", minutes, hours, remainingMinutes);
                           
    }
}

