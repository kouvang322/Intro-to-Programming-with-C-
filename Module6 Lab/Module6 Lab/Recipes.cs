using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6_Lab
{
    public class Recipe
    {
        private List<Ingredients> recipesList = new List<Ingredients>();

        private string recipeName;
        public Recipe(string name)
        {
            recipeName = name;
        }

        public override string ToString()
        {
            var str = recipeName + "\n";
            for (int i = 0; i < recipesList.Count; i++)
            {
                Ingredients listRecipes = recipesList[i];
                str += listRecipes.ToString() + "\n";
            }
            return str;
        }
        public void AddRecipeIngredients()
        {
            string ingredientName = "";
            int ingredientQuantity;
            string ingredientMeasureType;

            ingredientName = GetValidIngredientInput();

            while (ingredientName != "NA")
            {

                ingredientQuantity = GetValidIntQuantity();

                Console.Write("Measurement: ");
                ingredientMeasureType = Console.ReadLine();
                Ingredients ingredientsInformation = new Ingredients(ingredientName, ingredientQuantity, ingredientMeasureType);
                recipesList.Add(ingredientsInformation);

                ingredientName = GetValidIngredientInput();
            }


        }
        public void ListRecipes()
        {
            for (int i = 0; i < recipesList.Count; i++)
            {
                Ingredients listRecipes = recipesList[i];
                Console.WriteLine(listRecipes.ToString());
            }
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

        public static string GetValidIngredientInput()
        {
            Console.Write("Ingredient (NA when done): ");

            string userInput = Console.ReadLine();

            if (userInput == "na")
            {
                userInput = userInput.ToUpper();
            }
            return userInput;
        }

        public static int GetValidIntQuantity()
        {
            Console.Write("Quantity: ");
            string userInput = (Console.ReadLine());

            while (!(int.TryParse(userInput, out int i)))
            {
                Console.WriteLine("Enter a number only please.");
                Console.Write("Quantity: ");
                userInput = Console.ReadLine();
            }

            int quantityNumInput = Convert.ToInt32(userInput);

            return quantityNumInput;
        }
    
    }

}
