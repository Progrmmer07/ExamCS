namespace Task1;

public class Manager
{
    private List<Event> events = new List<Event>();

    public void Add(Event eventt)
    {
        try
        {
            if (eventt == null)
            {
                Console.WriteLine("Event cannot be null.");
            }

            events.Add(eventt);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}");
        }
        finally
        {
            Console.WriteLine("Event added successfully.");
        }
    }

    public void Remove(string title)
    {
        try
        {
            var existing = events.FirstOrDefault(e => e.Title == title);
            if (existing == null)
            {
                Console.WriteLine("Event not found.");
            }

            events.Remove(existing);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}");
        }
        finally
        {
            Console.WriteLine("Event deleted successfully.");
        }
    }

    public List<Event> SearchByDate(DateTime date)
    {
        try
        {
            var existing2 = events.Where(e => e.StartTime.Date <= date.Date && e.EndTime.Date >= date.Date).ToList();
            if (existing2.Count == 0)
            {
                Console.WriteLine("Nothing to search");
            }
            return existing2;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}");
            return new List<Event>();
        }
    }
}

