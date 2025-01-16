// Create application main menu
public class MenuItem
{
    public string Option { get; set; }

}



// Create class to display menu items

public class DisplayMenu
{
    public void DisplayMenuItems(List<MenuItem> menuItems)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nPlease select an option from the menu below:");
            for (int i = 0; i < menuItems.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {menuItems[i].Option}");
            }
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("View all products!");
                    ProductInventory productInventory = new ProductInventory();
                    productInventory.ViewAllProducts();
                    break;
                case "2":
                    Console.WriteLine("Add a product to inventory!");
                    ProductInventory addProductToInventory = new ProductInventory();
                    addProductToInventory.AddProduct();
                    break;
                case "3":
                    Console.WriteLine("Delete a product from inventory!");
                    ProductInventory deleteProductFromInventory = new ProductInventory();
                    deleteProductFromInventory.DeleteProduct();
                    break;
                case "4":
                    Console.WriteLine("Update a product's details!");
                    ProductInventory updateProductDetails = new ProductInventory();
                    updateProductDetails.UpdateProduct();
                    break;
                case "5":
                    Console.WriteLine("View products by product type!");
                    ProductInventory lookupProductByType = new ProductInventory();
                    lookupProductByType.ViewProductsByType();
                    break;case "6":
                    Console.WriteLine("Exit products inventory application!");
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

        }

    }
}