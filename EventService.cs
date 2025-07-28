public static class EventService
{
    public static Task<List<Event>> GetEventsAsync()
    {
        return Task.FromResult(new List<Event>
        {
            new Event { Id = 1, Name = "Tech Conference", Date = DateTime.Now.AddDays(10), Location = "San Francisco" },
            new Event { Id = 2, Name = "Music Festival", Date = DateTime.Now.AddDays(20), Location = "Los Angeles" }
        });
    }
}
