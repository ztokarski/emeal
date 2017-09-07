using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace emeal.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
        public virtual User Author { get; set; }
        public virtual List<Ingredient> Ingredients { get; set; }
        public virtual List<Step> Steps { get; set; }

        [DataType("Url")]
        [Display(Name = "Meal image")]
        public string PathToImage { get; set; }

        [Display(Name = "Difficulty")]
        public Difficulty DifficultyLevel { get; set; }

        [Display(Name = "Added on")]
        public DateTime WhenAdded { get; set; }

        [Display(Name = "Preparation time")]
        public int EstimatedTime { get; set; }

        public int Popularity { get; set; }

        public int Rating { get; set; }
    }

    public enum Difficulty
    {
        Easy,
        Medium,
        Hard
    }
}