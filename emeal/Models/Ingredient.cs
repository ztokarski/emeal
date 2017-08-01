using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace emeal.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public string Amount { get; set; }
        public Unit UnitType { get; set; }
    }

    public enum Unit
    {
        szt, g, dag, kg, ml, l
    }
}