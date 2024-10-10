namespace InventoryManagement;

public class Adding
{

    public static Product AddProduct()
    {
        int category = -1;
        int quantity;
        string name;
        float price;

        while (true)
        {
            Console.Write("Type Name: ");
            name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Error: Name cannot be empty.");
                continue;
            }

            Console.Write("Type Price: ");
            if (!float.TryParse(Console.ReadLine(), out price) || price <= 0)
            {
                Console.WriteLine("Error: Invalid price. Please enter a positive number.");
                continue;
            }

            Console.Write("Type Quantity: ");
            if (!int.TryParse(Console.ReadLine(), out quantity) || quantity < 0)
            {
                Console.WriteLine("Error: Invalid quantity. Please enter a non-negative integer.");
                continue;
            }

            for (int i = 0; i < Product.Categories.Length; i++)
            {
                Console.Write($" {i}. {Product.Categories[i]}");
            }

            Console.WriteLine("\nChoose a Category: ");
            if (!int.TryParse(Console.ReadLine(), out category) || category < 0 ||
                category >= Product.Categories.Length)
            {
                Console.WriteLine("Error: Invalid category. Please choose a valid category number.");
                continue;
            }

            break;
        }

        return new Product(name, Product.Categories[category], price, quantity);
    }
}
