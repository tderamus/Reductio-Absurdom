using System.IO.MemoryMappedFiles;

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
                break;
            case "3":
                Console.WriteLine("Delete a product from inventory!");
                break;
            case "4":
                Console.WriteLine("Update a product's details!");
                break;
            case "5":
                Console.WriteLine("Exit product inventory application!");
                exit = true;
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }

    }
        
  }
}