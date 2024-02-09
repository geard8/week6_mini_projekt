namespace week6_mini_projekt
{
    static internal class Utils
    {
        /* UserCreateProduct method for user to create a Product by user input from consol answers to questions with 
         * option to quit creation of Product my entering "q" or "Q" as an answer to any question.
         * Return Product or null.
         * - Return Product based on users answers if user complate answer all question with valid answer.
         * - Return null if user quit by entering "q" or "Q" as an answer to any question.
        */
        public static Product? UserCreateProduct()
        {
            string newCategory;
            string newName;
            float newPriceFloat;
            int maxLength = 25; // max length for newCategory and newName

            Console.WriteLine("Add a new product - follow the steps | Done adding product - enter only: \"Q\"");

            // get user input for newCategory
            while (true)
            {
                

                Console.Write("Enter a Category: ");
                newCategory = Console.ReadLine();
                if (newCategory == "q" ||  newCategory == "Q") {return null;}
                else if (newCategory.Length > maxLength) 
                { 
                    Display.DisplayColorMsg("Too long can't be longer then " + maxLength + " characters", "red"); 
                }
                else if (newCategory.Trim().Length != 0) { break; }
                else
                {
                    Display.DisplayColorMsg("Category can not be empty", "red");
                }
            }

            // get user input for newName
            while (true)
            {
                Console.Write("Enter a Name: ");
                newName = Console.ReadLine();
                if (newName == "q" || newName == "Q") { return null; }
                else if (newName.Length > maxLength)
                {
                    Display.DisplayColorMsg("Too long can't be longer then " + maxLength + " characters", "red");
                }
                else if (newName.Trim().Length != 0) { break; }
                else
                {
                    Display.DisplayColorMsg("Name can not be empty", "red");
                }
            }

            // get user input for newPriceFloat
            while (true)
            {
                Console.Write("Enter a Price: ");
                string newPriceStr = Console.ReadLine();
                if (newPriceStr == "q" || newPriceStr == "Q") { return null; }
                else if (!float.TryParse(newPriceStr, out newPriceFloat))
                {
                    Display.DisplayColorMsg("Not a valid price. Exemple of valid price is: 31 or 43,99", "red");
                }
                else
                {
                    break;
                }
            }
            // create new Product based on user input and return the created Product
            return new Product(newCategory, newName, newPriceFloat);
        }

        // UserCreateProducts method for allowing user to create products until user quit creating products
        // and add all created products to list Products from class Product
        public static void UserCreateProducts()
        {
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
        }
    }
}
