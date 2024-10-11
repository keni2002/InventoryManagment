namespace InventoryManagement;

public class Adding
{

    public static Product AddProduct()
    {
        int category;
        int quantity;
        string name;
        float price;

        while (true)
        {
            Console.Write("Type Name: ");
            name = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(name))
            {
                break;//good
            }
            Console.WriteLine("Error: Name cannot be empty.");
        }

        while (true)
        {
            Console.Write("Type Price: ");
            if (float.TryParse(Console.ReadLine(), out price) && price >=0)
            {
                break;
            }
            Console.WriteLine("Error: Invalid price. Please enter a positive number.");
        }

        while (true)
        { 
            Console.Write("Type Quantity: "); 
            if (int.TryParse(Console.ReadLine(), out quantity) && quantity > 0)
            {
                break;
            }
            Console.WriteLine("Error: Invalid quantity. Please enter a non-negative integer."); 
        }
        for (int i = 0; i < Product.Categories.Length; i++)
        { 
            Console.Write($" {i}. {Product.Categories[i]}");
        }
        while (true)
        { 
            Console.WriteLine("\nChoose a Category: "); 
            if (int.TryParse(Console.ReadLine(), out category) && (category >= 0 &&
                                                            category < Product.Categories.Length))
            {
                
                break;
            }
            Console.WriteLine("Error: Invalid category. Please choose a valid category number.");
        }
        
        return new Product(name, Product.Categories[category], price, quantity);
    }
}
