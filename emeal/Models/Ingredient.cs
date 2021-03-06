﻿using System.ComponentModel.DataAnnotations;

namespace emeal.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public virtual Product Product { get; set; }
        public double Amount { get; set; }

        [Display(Name = "Unit")]
        public Unit UnitType { get; set; }
        public string Description { get;  set; }
    }

    public enum Unit
    {
        szt,
        g,
        dag,
        kg,
        ml,
        l,
        łyż,
        łyżeczka,
        gałąz,
        główka,
        szczypta,
        puszka,
        ząbek,
        kromka
    }
}