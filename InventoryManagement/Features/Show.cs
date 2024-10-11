namespace InventoryManagement;

public class Show
{
    public static void ShowProducts(List<Product> products)
    {
        if (products.Count == 0)
        {
            Console.WriteLine("There are no products yet.");
        }
        else
        {

            foreach (Product product in products)
            {
                Console.WriteLine($"Name: {product.Name}");
                Console.WriteLine($"Price: {product.Price}");
                Console.WriteLine($"Quantity: {product.Quantity}");
                Console.WriteLine($"Total Price: {product.Price*product.Quantity}");
                Console.WriteLine($"Category: {product.Category}");
                Console.WriteLine();
                
            }
        }
    }

    public static void ShowByCategory()
    {
        
    }
}