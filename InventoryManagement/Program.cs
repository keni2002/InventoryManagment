
using InventoryManagement;
List<Product> products = new List<Product>();
int opt = 1;
while (opt != 0)
{
    
    Message.Show();
    opt = Convert.ToInt32(Console.ReadLine());
    switch (opt)
    {   
        case 1:
            products.Add(Adding.AddProduct());
            Console.Write("Product added. Press any key to continue...");
            Console.ReadLine();
            break;
        case 2:
            Console.Clear();
            Show.ShowProducts(products);
            Console.Write("Product added. Press any key to continue...");
            Console.ReadLine();
            break;
        
    }
}

