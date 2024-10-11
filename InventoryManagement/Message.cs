namespace InventoryManagement;

public class Message
{
    public static void Show()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Inventory Management Console\n" +
                          "1. Add a new Product\n" +
                          "2. Show all Product\n" +
                          "3. Show products by category \n" +
                          "0. Exit\n"+
                          "Type a option:");
    }
}