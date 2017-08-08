using System.ComponentModel.DataAnnotations;

namespace emeal.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public string PathToImage { get; set; }
    }
}