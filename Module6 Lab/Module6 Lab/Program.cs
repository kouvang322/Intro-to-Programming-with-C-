using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
           

            List<Recipe> recipeList = new List<Recipe>();

            string usersChoice = GetValidChoiceInput();
            while (usersChoice != "N")
            {
                Console.Write("Enter recipe name: ");
                string recipeName = Console.ReadLine();
                Recipe myRecipes = new Recipe(recipeName);
                recipeList.Add(myRecipes);
                myRecipes.AddRecipeIngredients();
                usersChoice = GetValidChoiceInput();
            }

            for (int i = 0; i < recipeList.Count; i++)
            {
                Recipe listRecipes = recipeList[i];
                Console.WriteLine(listRecipes.ToString());
            }

            Console.Read();
        }
          

        public static string GetValidChoiceInput()
        {
            Console.Write("Enter another recipe? (Y/N) ");

            string userInput = Console.ReadLine().ToUpper();

            while (userInput.Length > 1 && userInput != "Y" && userInput != "N")
            {
                Console.WriteLine("Please enter a letter that matches an availiable option.");
                Console.Write("Enter another recipe? (Y/N) ");
                userInput = Console.ReadLine().ToUpper();
            }
            return userInput;
        }

    }
}
