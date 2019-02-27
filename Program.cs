using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            //za broj 1
            Console.Write("Enter first number (num1):");
            var num1 = Console.ReadLine();
            decimal successufulNum1;
            bool isSuccessufulNum1 = decimal.TryParse(num1, out successufulNum1);

            if (isSuccessufulNum1)
            {
                Console.WriteLine("Num1 is a Number! You are OK :)");
            }
            else
            {
                Console.WriteLine("Num1 is not a Number! Please enter a number");
                Console.ReadLine();
                Environment.Exit(0);
            }


            //za broj 2
            Console.Write("Enter second number (num2):");
            var num2 = Console.ReadLine();
            decimal successufulNum2;
            bool isSuccessufulNum2 = decimal.TryParse(num2, out successufulNum2);

            if (isSuccessufulNum2)
            {
                Console.WriteLine("Num2 is a Number! You are OK :)");
            }
            else
            {
                Console.WriteLine("Num2 is not a Number! Please enter a number");
                Console.ReadLine();
                Environment.Exit(0);
            }
           
       
            //za +,-,*,/
            Console.Write("Enter one operation +,-,* or /: ");
            var operation = Console.ReadLine();

           
            decimal sum = successufulNum1 + successufulNum2;
            decimal minus = successufulNum1 - successufulNum2;
            decimal multi = successufulNum1 * successufulNum2;
            decimal division = successufulNum1 / successufulNum2;

           

            if (operation == "+")
            {
                Console.WriteLine("Sum of " + " " + successufulNum1 + " and " + successufulNum2 + " is: " + sum);
            }

            if(operation == "-")
            {
                Console.WriteLine("Extraction of" + " " + successufulNum1 + " and " + successufulNum2 + " is: " + minus);
            }

            if (operation == "*")
            {
                Console.WriteLine("Miltiplication of" + " " + successufulNum1 + " and " + successufulNum2 + " is: " + multi);
            }
            if (operation == "/")
            {
                Console.WriteLine("Division of" + " " + successufulNum1 + " and " + successufulNum2 + " is: " + division);
            }
            else if ( operation != "+" & operation != "-" & operation != "*" & operation !="/")
            {
                Console.WriteLine("You entered a non-existent operation. Please enter one operation +,-,* or /");
                Console.ReadLine();
                Environment.Exit(0);
            }
            
            Console.ReadLine();
        }
    }
}
