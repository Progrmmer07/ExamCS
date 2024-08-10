using Task2;

Inventory<Item> inventory = new Inventory<Item>();
Item item1 = new Item()
{
    Name = "Laptop",
    Category = "Windows",
    Type = ItemType.OfficeItem,
};

Item item2 = new Item()
{
    Name = "Car",
    Category = "Toyota",
    Type = ItemType.HomeItem
};

inventory.AddItem(item1);
inventory.AddItem(item2);

inventory.RemoveItem(item2);

var categories = inventory.GetItemsByCategory("Windows");
foreach (var item in categories)
{
    Console.WriteLine($"Item -> {item.Name}, Category -> {item.Category}, Type -> {item.Type}");
}

var type = inventory.GetItemsByType(ItemType.OfficeItem);
foreach (var item in type)
{
    Console.WriteLine($"Item -> {item.Name}, Category -> {item.Category}, Type -> {item.Type}");
}

var all = inventory.GetAllItems();
foreach (var item in all)
{
    Console.WriteLine($"Item -> {item.Name}, Category -> {item.Category}, Type -> {item.Type}");
}