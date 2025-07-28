namespace EventEase.Models
{
    public class Event
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public DateTime Date { get; set; }
        public string? Location { get; set; }
    }
}
