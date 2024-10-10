namespace InventoryManagement;

public class Message
{
    public static void Show()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Inventory Management Console");
        Console.WriteLine("1. Add a new item");
        Console.WriteLine("2. Show all items");
        Console.Write("Type a option: ");
    }
}