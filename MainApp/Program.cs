using Task1;

Manager managment = new Manager();

Event event1 = new Event()
{
    Title = "Test",
    Description = "Checking",
    StartTime = DateTime.Now,
    EndTime = DateTime.Now.AddHours(1)
};

Event event2 = new Event()
{
    Title = "Test2",
    Description = "Start checking",
    StartTime = DateTime.Now,
    EndTime = DateTime.Now.AddHours(2)
};

managment.Add(event1);
managment.Add(event2);

managment.Remove("Checking");

var eventsOnDate = managment.SearchByDate(DateTime.Now.AddHours(2));
foreach (var item in eventsOnDate)
{
    Console.WriteLine($"Event: {item.Title}, Start Time: {item.StartTime}, End Time: {item.EndTime}");
}
