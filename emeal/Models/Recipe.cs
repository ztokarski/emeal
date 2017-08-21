using System;
using System.Collections.Generic;

namespace emeal.Models
{
    public class Recipe
    {
        public int? Id { get; set; }
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

        public Recipe(int id, string name, string description, User author, List<Ingredient> ingredients,
            List<Step> steps, string pathToImage, Difficulty difficultyLevel, DateTime whenAdded, int estimatedTime,
            int popularity, int rating)
        {
            Id = id;
            Name = name;
            Description = description;
            Author = author;
            Ingredients = ingredients;
            Steps = steps;
            PathToImage = pathToImage;
            DifficultyLevel = difficultyLevel;
            WhenAdded = whenAdded;
            EstimatedTime = estimatedTime;
            Popularity = popularity;
            Rating = rating;
        }

        public Recipe(string name, string description, User author, List<Ingredient> ingredients,
            List<Step> steps, string pathToImage, Difficulty difficultyLevel, int estimatedTime)
        {
            Id = null;
            Name = name;
            Description = description;
            Author = author;
            Ingredients = ingredients;
            Steps = steps;
            PathToImage = pathToImage;
            DifficultyLevel = difficultyLevel;
            EstimatedTime = estimatedTime;
            Popularity = 0;
            Rating = 0;
        }

        public Recipe()
        {
        }
    }

    public enum Difficulty
    {
        Easy,
        Medium,
        Hard
    }
}