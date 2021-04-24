namespace PetStoreApi.Models
{
    public class Pet
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string[] photoUrls { get; set; }
    }
}