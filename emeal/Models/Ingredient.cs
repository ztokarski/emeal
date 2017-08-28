using System.ComponentModel.DataAnnotations;

namespace emeal.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public virtual Product Product { get; set; }
        [Required]
        public string Amount { get; set; }

        [Required]
        [Display(Name = "Unit")]
        public Unit UnitType { get; set; }
    }

    public enum Unit
    {
        szt,
        g,
        dag,
        kg,
        ml,
        l
    }
}