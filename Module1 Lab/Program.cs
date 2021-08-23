using System;

namespace Module1_Lab
{
    class Program
    {
        static void Main(string[] args)
        {

            // Lab A portion //

            Console.Write("Input first number> ");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second number> ");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(firstNum + " + " + secondNum + " = " + (firstNum + secondNum));
            Console.WriteLine(firstNum + " - " + secondNum + " = " + (firstNum - secondNum));
            Console.WriteLine(firstNum + " * " + secondNum + " = " + (firstNum * secondNum));

            Console.Write("Input width> ");
            int widthNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input height> ");
            int heightNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Area: " + (widthNum * heightNum));

            Console.WriteLine("Press any key to continue....");


            // Lab B portion //

            Console.Write("How many cupcakes would you like to make? ");
            int cupcakeNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Modified recipe for " + cupcakeNum + " cupcakes");

            // Eggs required for 1 cupcake math
            double eggsReq = (double)cupcakeNum * 1/2;

            // Cups of suger required for 1 cupcake math
            double sugerReq = (double)cupcakeNum * 1/8;

            // Packages of cream cheese required for 1 cupcake math  
            double creamCheeseReq = (double)cupcakeNum * 3/8;

            // Teaspoons vanilla required for 1 cupcake math
            double vanillaReq = (double)cupcakeNum * 1/8;
            
            Console.WriteLine($"{eggsReq:n2}" + " eggs");
            Console.WriteLine($"{sugerReq:n2}" + " cups suger");
            Console.WriteLine($"{creamCheeseReq:n2}" + " packages of cream cheese");
            Console.WriteLine($"{vanillaReq:n2}" + " teaspoons vanilla");

            Console.WriteLine("Press any key to continue....");

        }
    }
}
