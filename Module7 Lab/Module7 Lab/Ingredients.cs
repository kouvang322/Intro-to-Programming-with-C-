using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7_Lab
{
    public class Ingredients
    {
        private string ingredient;
        public string Ingredient { get; set; }

        private int quantity;
        public int Quantity 
        {
            get { return quantity; }
            set { if(quantity > 0) quantity = value;}
        }

        private string measurementType;
        public string MeasurementType { get; set; }


        public Ingredients(string myIngredient, int myQuantity, string myMeasurement)
        {
            ingredient = myIngredient;
            quantity = myQuantity;
            measurementType = myMeasurement;
        }

        public override string ToString()
        {
            return String.Format($"{quantity} {measurementType} {ingredient}");
        }

    }
}
