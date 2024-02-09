using week6_mini_projekt;

// set newProduct to a new Product based on user input or null if user quit the process of creating new Product
Product newProduct = Utils.UserCreateProduct();

if (newProduct != null) { Display.DisplayColorMsg("THE END newProduct EXIST", "yellow"); }
    
else { Display.DisplayColorMsg("THE END DONT newProduct EXIST", "yellow"); }
