namespace AspApiDemo.Models
{
    public class Pet
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string[] PhotoUrls { get; set; }
        public string Status { get; set; }
    }
}