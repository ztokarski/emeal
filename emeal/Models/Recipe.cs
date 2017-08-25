using System;
using System.Collections.Generic;

namespace emeal.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual User Author { get; set; }
        public virtual List<Ingredient> Ingredients { get; set; }
        public virtual List<Step> Steps { get; set; }
        public string PathToImage { get; set; }

        public Difficulty DifficultyLevel { get; set; }
        public DateTime WhenAdded { get; set; }
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