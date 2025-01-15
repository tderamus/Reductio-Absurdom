// Create application main menu
using System.Net;

string greeting = "Welcome to the Reductio & Absurdum Product Inventory Management System!";

List<MenuItem> menuItems = new List<MenuItem>
{
    new MenuItem() { Option = "View all products!" },
    new MenuItem() { Option = "Add a product to inventory!" },
    new MenuItem() { Option = "Delete a product from inventory!" },
    new MenuItem() { Option = "Update a product's details!" },
    new MenuItem() { Option = "Exit product inventory application!" },
};

Console.WriteLine(greeting);

// Display the main menu
DisplayMenu displayMenu = new DisplayMenu();
displayMenu.DisplayMenuItems(menuItems);


