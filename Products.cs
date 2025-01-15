/*
Products have a name, price (as a decimal), and a boolean to indicate whether they are still available. 
They also have a ProductTypeId, which categorize them into the following categories: apparel, 
potions, enchanted objects, and wands. When adding a product to the inventory, 
the user should be able to choose from these options to add a product type id to the new product.
 */

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }
    public int ProductTypeId { get; set; }
}

public class ProductType
{
    public int ProductTypeId { get; set; }
    public string ProductTypeName { get; set; }
}

public class ProductInventory
{
    public List<Product> Products { get; set; }
    public List<ProductType> ProductTypes { get; set; }
    public ProductInventory()
    {
        Products = new List<Product>
        {
            new Product() { Name = "Wizard Robe", Price = 50.00m, IsAvailable = true, ProductTypeId = 1 },
            new Product() { Name = "Healing Potion", Price = 10.00m, IsAvailable = true, ProductTypeId = 2 },
            new Product() { Name = "Magic Mirror", Price = 100.00m, IsAvailable = false, ProductTypeId = 3 },
            new Product() { Name = "Phoenix Feather Wand", Price = 35.00m, IsAvailable = false, ProductTypeId = 4 },
            new Product() { Name = "River Robe", Price = 55.00m, IsAvailable = false, ProductTypeId = 1 },
            new Product() { Name = "Sleeping Potion", Price = 65.00m, IsAvailable = true, ProductTypeId = 2 },
            new Product() { Name = "Past Mirror", Price = 85.00m, IsAvailable = true, ProductTypeId = 3 },
            new Product() { Name = "Skyline Wand", Price = 95.00m, IsAvailable = false, ProductTypeId = 4 },
            new Product() { Name = "Warlock Robe", Price = 45.00m, IsAvailable = true, ProductTypeId = 1 },
            new Product() { Name = "Beauty Potion", Price = 25.00m, IsAvailable = false, ProductTypeId = 2 },
            new Product() { Name = "Future Mirror", Price = 75.00m, IsAvailable = true, ProductTypeId = 3 },
            new Product() { Name = "Blueface Wand", Price = 95.00m, IsAvailable = false, ProductTypeId = 4 }
        };

        ProductTypes = new List<ProductType>
        {
            new ProductType() { ProductTypeId = 1, ProductTypeName = "Apparel" },
            new ProductType() { ProductTypeId = 2, ProductTypeName = "Potions" },
            new ProductType() { ProductTypeId = 3, ProductTypeName = "Enchanted Objects" },
            new ProductType() { ProductTypeId = 4, ProductTypeName = "Wands" }
        };
    }
    public void AddProduct()
    {
        Product newProduct = new Product();
        Console.WriteLine("Enter the name of the product:");
        newProduct.Name = Console.ReadLine();
        Console.WriteLine("Enter the price of the product:");
        newProduct.Price = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Is the product available? (true/false):");
        newProduct.IsAvailable = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("Choose a product type id:");
        foreach (ProductType productType in ProductTypes)
        {
            Console.WriteLine($"{productType.ProductTypeId}. {productType.ProductTypeName}");
        }
        newProduct.ProductTypeId = Convert.ToInt32(Console.ReadLine());
        Products.Add(newProduct);
        Console.WriteLine("Product added successfully!");
    }
    public void ViewAllProducts()
    {
        foreach (Product product in Products)
        {
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Available: {product.IsAvailable}, Product Type: {ProductTypes.Find(pt => pt.ProductTypeId == product.ProductTypeId).ProductTypeName}");
        }
    }
    public void DeleteProduct()
    {
        Console.WriteLine("Enter the name of the product to delete:");
        string productName = Console.ReadLine();
        Product productToDelete = Products.Find(p => p.Name == productName);
        if (productToDelete != null)
        {
            Products.Remove(productToDelete);
            Console.WriteLine("Product deleted successfully!");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }
    public void UpdateProduct()
    {
        Console.WriteLine("Enter the name of the product to update:");
        string productName = Console.ReadLine();
        Product productToUpdate = Products.Find(p => p.Name == productName);
        if (productToUpdate != null)
        {
            Console.WriteLine("Enter the new name of the product:");
            productToUpdate.Name = Console.ReadLine();
            Console.WriteLine("Enter the new price of the product:");
            productToUpdate.Price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Is the product available? (true/false):");
            productToUpdate.IsAvailable = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Choose a product type id:");
            foreach (ProductType productType in ProductTypes)
            {
                Console.WriteLine($"{productType.ProductTypeId}. {productType.ProductTypeName}");
            }
            productToUpdate.ProductTypeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Product updated successfully!");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }
}