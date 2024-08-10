namespace Task2;

public class Item
{
    public string Name { get; set; }
    public string Category { get; set; }
    public ItemType Type { get; set; }

    public Item(string name, string category, ItemType type)
    {
        Name = name;
        Category = category;
        Type = type;
    }

    public Item() { }
}

