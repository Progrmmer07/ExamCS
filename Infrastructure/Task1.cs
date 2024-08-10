using System.IO.Enumeration;

namespace Task1;

public class Event
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }

    public Event(string title, string description, DateTime startTime, DateTime endTime)
    {
        Title = title;
        Description = description;
        StartTime = startTime;
        EndTime = endTime;
    }

    public Event() { }
}
    