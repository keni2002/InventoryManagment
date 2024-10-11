namespace InventoryManagement;

public class Product
{
    
    public static readonly string[] Categories = new[]
    {
        "Food", "Clothes", "Entertainment", "Tools", "Technology"
    };
    public  string Category { get; set; }
    public string Name { get; set; }
    public  float Price { get; set; }
    public int Quantity { get; set; }
    
    //constructor
    
    public Product(string name, string category, float price, int quantity=0)
    {
        Name = name;
        Category = category;
        Price = price;
        Quantity = quantity;
        
    }
    public static decimal CalcPriceIVA(decimal priceWithou, decimal rateIva,decimal amount, out decimal porcent)
    {
        porcent = amount*100/priceWithou;
    
        //apply IVA
        return priceWithou * (1 + rateIva) - amount;
    }

}