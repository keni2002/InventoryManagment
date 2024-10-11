namespace InventoryManagement;
public class Show
{
    private static void PrintProduct(Product product)
    {
        Console.WriteLine($"Name: {product.Name}");
        Console.WriteLine($"Price: {product.Price}");
        Console.WriteLine($"Quantity: {product.Quantity}");
        Console.WriteLine($"Total Price: {product.Price*product.Quantity}");
        Console.WriteLine($"Category: {product.Category}");
        Console.WriteLine();
    }
    public static void ShowProducts(List<Product> products)
    {
        if (products.Count == 0)
        {
            Console.WriteLine("No products.");
        }
        else
        {
            Console.WriteLine("All Products:");
            foreach (Product product in products)
            {
                PrintProduct(product);
            }
        }
    }
    public static void ShowByCategory(List<Product> products)
    
    {
        //show category to user
        for (int i = 0; i < Product.Categories.Length; i++)
        {
            Console.Write($" {i}. {Product.Categories[i]}");
        }
        Console.Write("\nInset one or more product categories: ");
        //save the array of category
        string numsCategory = Console.ReadLine();
        //make a array
        string[] words = numsCategory.Split(' ');
        
        foreach (string category in words)
        {
            Console.WriteLine($"Category: {Product.Categories[Convert.ToInt32(category)]}==============");
            foreach (Product product in products)
            {
                if (Product.Categories[Convert.ToInt32(category)] == product.Category)
                {
                    PrintProduct(product);
                }
            }
        }
    }

    
}