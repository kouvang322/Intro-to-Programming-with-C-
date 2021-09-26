using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6_Lab
{
    public class Ingredients
    {
        private string ingredient;
        private int quantity;
        private string measurementType;

        public Ingredients(string myIngredient, int myQuantity, string myMeasurement)
        {
            ingredient = myIngredient;
            quantity = myQuantity;
            measurementType = myMeasurement;
        }

        public string ToString()
        {
            return String.Format($"{quantity} {measurementType} {ingredient}");
        }


        public string GetIngredient()
        {
            return ingredient;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public string GetMeasurement()
        {
            return measurementType;
        }

        public void SetIngredient(string myIngredient)
        {
            ingredient = myIngredient;
        }

        public void SetQuantity(int myQuantity)
        {
            if (myQuantity > 0)
            {
                quantity = myQuantity;
            }
        }

        public void SetMeasurement(string myMeasurement)
        {
            measurementType = myMeasurement;
        }
        
    }
}
