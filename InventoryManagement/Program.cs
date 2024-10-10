
using InventoryManagement;
List<Product>  products = new List<Product>();
int opt = 1;
while (opt != 0)
{
    
    Message.Show();
    opt = Convert.ToInt32(Console.ReadLine());
    switch (opt)
    {   
        case 1:
            products.Add(Adding.AddProduct());
            break;
        
        
    }
}

