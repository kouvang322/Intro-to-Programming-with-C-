using System;

namespace Module2_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.Write("Enter amount in ml> ");
			int amountNum = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Choose your conversion type:");
			Console.WriteLine("1. Teaspoons");
			Console.WriteLine("2. Tablespoons");
			Console.WriteLine("3. Cups");
			Console.WriteLine("4. Quarts");
			Console.Write("> ");
			int typeConvert = Convert.ToInt32(Console.ReadLine());

			if (typeConvert == 1)
			{
				Console.WriteLine(amountNum + " ml is " + $"{(amountNum/4.929):n1}" + " Teaspoons");
			}
			else if (typeConvert == 2)
			{
				Console.WriteLine(amountNum + " ml is " + $"{(amountNum/14.787):n1}" + " Tablespoons");
			}
			else if (typeConvert == 3)
			{
				Console.WriteLine(amountNum + " ml is " + $"{(amountNum/240.0):n1}" + " Cups");
			}
			else if (typeConvert == 4)
			{
				Console.WriteLine(amountNum + " ml is " + $"{(amountNum/946.0):n1}" + " Quarts");
			}
		}
    }
}
