using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6_Assignment
{
    class Item
    {
        private string item;
        private int quantityInMachine;
        private double pricePerUnit;
    
        public Item(string myItem, int myQuantityInMachine, double myPricePerUnit)
        {
            item = myItem;
            quantityInMachine = myQuantityInMachine;
            pricePerUnit = myPricePerUnit;
        }

        public string ToString()
        {
            return String.Format($"{item} {pricePerUnit:c2}");
        }

        public string GetItem()
        {
            return item;
        }

        public int GetQuantityInMachine()
        {
            return quantityInMachine;
        }

        public int GetNewQuantity()
        {
            return quantityInMachine -= 1;
        }

        public double GetPricePerUnit()
        {
            return pricePerUnit;
        }

        public void SetItem(string myItem)
        {
            item = myItem;
        }

        public void SetQuantityInMachine(int myQuantityInMachine)
        {
            if (myQuantityInMachine > 0)
            {
                quantityInMachine = myQuantityInMachine;
            }
        }

        public void SetPricePerUnit(double myPricePerUnit)
        {
            if (myPricePerUnit > 0)
            {
                pricePerUnit = myPricePerUnit;
            }
        }
    }
}
