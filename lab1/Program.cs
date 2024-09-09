using lab1;

class Program
{
    static void Main()
    {
        var products = new List<Product>
        {
            new Toy("Teddy Bear", 2999, "3-5 years"),
            new Meat("Chicken Breast", 1250, "Poultry"),
            new Drinks("Orange Juice", 399, false),
            new Drinks("Beer", 500, true),
            new Electronics("Smartphone", 29999, "2 years"),
            new Bread("Whole Wheat Bread", 299, "Whole Wheat", DateTime.Now.AddDays(7))
        };

        

 
        foreach (var product in products)
        {
            
            Console.WriteLine(product.GetInformation());

        }
    }
}