using System.ComponentModel.DataAnnotations;

namespace emeal.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "User avatar")]
        public string PathToImage { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}