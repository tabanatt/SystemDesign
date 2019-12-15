namespace SystemDesign.Models
{
    public class Guarantee
    {
        public int Id { get; set; }
        public long Price { get; set; }
        public string SourceName { get; set; }
        public string DestinationName { get; set; }
    }
}
