
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
            Console.Write("Press any key to continue...");
            Console.ReadLine();
            break;
        case 3:
            Console.Clear();
            Show.ShowByCategory(products);
            Console.Write("Press any key to continue...");
            Console.ReadLine();
            break;
        case 4:
            Console.Clear();
            double amount = 0;
            foreach (Product p in products)
            {
                amount += p.Price*p.Quantity;
            }
            Console.WriteLine($"Inventory total amount: ${Math.Round(amount,2)}");
            Console.Write("Press any key to continue...");
            Console.ReadLine();
            break;
        case 5:
            Console.Clear();
            Console.Write("Type a price: ");
            decimal price = Convert.ToInt32(Console.ReadLine());
            
            //INvocacion de un out muy util para volcar info en var page 131
            decimal porcentuout;
            Product.CalcPriceIVA(price, (decimal)0.21, 5, out porcentuout);
            Console.WriteLine("Press any key to continue...");
            Console.WriteLine(porcentuout);
            Console.ReadLine();
            break;
    }
}

