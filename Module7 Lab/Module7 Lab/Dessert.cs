using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7_Lab
{
    public class Dessert : Recipes
    {
        public bool Frozen { get; set; }
        public Dessert(string recipeName): base(recipeName) { }
    }
}
