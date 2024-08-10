
using Task2;

public class Inventory<T> where T : Item
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        try
        {
            if (item != null)
            {
                Console.WriteLine("Item can't be null.");
            }

            items.Add(item);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}");
        }
        finally
        {
            Console.WriteLine("Item added successfully.");
        }
    }

    public void RemoveItem(T item)
    {
        try
        {
            if (item == null)
            {
                Console.WriteLine("Item can't be null.");
            }
            items.Remove(item);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}");
        }
        finally
        {
            Console.WriteLine("Item removed successfully.");
        }
    }

    public List<T> GetItemsByCategory(string category)
    {
        try
        {
            var existing = items.Where(i => i.Category == category).ToList();
            if (existing.Count == 0)
            {
                Console.WriteLine("Item is not found in category");
            }
            return existing;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}");
            return new List<T>();
        }
    }

    public List<T> GetItemsByType(ItemType type)
    {
        try
        {
            var existing = items.Where(i => i.Type == type).ToList();
            if (existing.Count == 0)
            {
                Console.WriteLine("No items found of the specified type.");
            }
            return existing;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error filtering items by type: {ex.Message}");
            return new List<T>();
        }
    }

    public List<T> GetAllItems()
    {
        try
        {
            if (items.Count == 0)
            {
                Console.WriteLine("items is empty ");
            }
            return items;
        }
        catch (Exception ex)
        {
            Console.WriteLine($" {ex.Message}");
            return new List<T>();
        }
    }
}