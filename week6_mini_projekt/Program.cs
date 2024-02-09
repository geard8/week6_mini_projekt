using week6_mini_projekt;

// While loop for user to make new products until user quit making products.
while (true)
{
    // set newProduct to a new Product based on user input or null if user quit the process of creating new Product
    Product newProduct = Utils.UserCreateProduct();

    // if user as created a new Product added it to list Products. Products is a static list from class Product.
    if (newProduct != null) 
    { 
        Display.DisplayColorMsg("THE END newProduct EXIST SO ADDING IT TO LIST", "yellow");
        Product.Products.Add(newProduct);
    }
    // else user has quit making new product then break while loop for making new products.
    else 
    { 
        Display.DisplayColorMsg("THE END DONT newProduct EXIST SO BREAKING WHILE LOOP", "yellow");
        break;
    }
}

foreach (Product product in Product.Products)
{
    Display.DisplayColorMsg("product: " + product.Category + product.Name + product.Price, "yellow");
}
