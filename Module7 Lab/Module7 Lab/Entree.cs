using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7_Lab
{
    public class Entree : Recipes
    {
        public string Nationality { get; set; }
        public Entree(string recipeName) : base(recipeName)
        {

        }
    }
}
