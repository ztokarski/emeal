namespace emeal.Models
{
    public class Step
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PathToImage { get; set; }
        public int Timer { get; set; }
        public int Order { get; set; }
    }
}