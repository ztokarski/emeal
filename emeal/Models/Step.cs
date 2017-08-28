using System.ComponentModel.DataAnnotations;

namespace emeal.Models
{
    public class Step
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        [Display(Name = "Step image")]
        public string PathToImage { get; set; }

        public int Timer { get; set; }
        public int Order { get; set; }
    }
}