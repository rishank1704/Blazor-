using EventEase.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

public class EventService
{
    // Existing code

    public async Task<List<Event>> GetEventsAsync()
    {
        // Replace with your actual data fetching logic
        await Task.Delay(100); // Simulate async work
        return new List<Event>
        {
            new Event { Id = 1, Name = "Sample Event 1" },
            new Event { Id = 2, Name = "Sample Event 2" }
        };
    }
}