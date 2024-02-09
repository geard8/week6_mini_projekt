using week6_mini_projekt;

// While loop for user to make new products until user quit making products.
while (true)
{
    // set newProduct to a new Product based on user input or null if user quit the process of creating new Product
    Product newProduct = Utils.UserCreateProduct();

    // if user as created a new Product added it to list Products. Products is a static list from class Product.
    if (newProduct != null) 
    { 
        Product.Products.Add(newProduct);
    }
    // else user has quit making new product then break while loop for making new products.
    else 
    { 
        break;
    }
}

// Show all products to user in a sorted way(low to high price) and total sum of all products price.
Product.ShowProducts();
