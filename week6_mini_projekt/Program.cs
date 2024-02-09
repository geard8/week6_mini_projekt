using week6_mini_projekt;

// User create products that are added to a list Products that is a static list from class Product.
Utils.UserCreateProducts();

// Show all products to user in a sorted way(low to high price) and total sum of all products price.
Product.ShowProducts();

ConsoleKeyInfo cki; // used to store key pressed by the user

// Give user option to make more products, search for a product or quit program by key input.
while (true)
{
    // Ask user and get key input from user to chose what to do next.
    while (true)
    {
        Console.WriteLine("Continue creating products - press \"P\" | search product - press \"S\" | To quit - press \"Q\"");
        cki = Console.ReadKey();
        Console.WriteLine();
        if (cki.Key == ConsoleKey.P || cki.Key == ConsoleKey.S || cki.Key == ConsoleKey.Q)
        {
            break;
        }
        else
        {
            Display.DisplayColorMsg("Not valid key, valid key are P, S or Q", "red");
        }
    }

    // If cki is P then user can create more products and after show list of all products
    if (cki.Key == ConsoleKey.P)
    {
        Utils.UserCreateProducts();
        Product.ShowProducts();
    }
    // if cki is S then search for products based on name.
    else if (cki.Key == ConsoleKey.S)
    {
        string userSearch = Utils.UserSearchProducts();
        Product.ShowProducts(userSearch);

    }
    else if (cki.Key == ConsoleKey.Q)
    {
        Display.DisplayColorMsg("Quiting program, hope to see you soon", "green");
        break;
    }
    else { 
        Display.DisplayColorMsg("ERROR: cki.Key it not P, S or Q yet have someway passed previus validation check to make sure it is.", "yellow");
        break;
    }
}
