namespace week6_mini_projekt
{
    internal class Product(string category, string name, float price)
    {
        public required string Category { get; set; } = category;
        public  string Name { get; set; } = name;
        public float Price { get; set; } = price;

        public static Product? UserCreateProduct()
        {
            string newCategory;
            string newName;
            float newPriceFloat;

            Console.WriteLine("Add a new product - follow the steps | Done adding product - enter: \"Q\"");
            while (true)
            {
                Console.WriteLine("Enter a Category: ");
                newCategory = Console.ReadLine();
                if (newCategory.Trim().Length != 0) { break; }
                else
                {
                    Display.DisplayColorMsg("Category can not be empty", "red");
                }
            }

            while (true)
            {
                Console.WriteLine("Enter a Name: ");
                newName = Console.ReadLine();
                if (newName.Trim().Length != 0) { break; }
                else
                {
                    Display.DisplayColorMsg("Name can not be empty", "red");
                }
            }

            while (true)
            {
                Console.WriteLine("Enter a Price: ");
                //TODO add checks for newCategory to handle if null
                string newPriceStr = Console.ReadLine();
                if (!float.TryParse(newPriceStr, out newPriceFloat))
                {
                     Display.DisplayColorMsg("Not a valid price. Exemple of valid price is: 31 or 43,99", "red");
                }
                else
                {
                    break;
                }
            }

            // TODO NEXT create Product based on user input

            return null;
        }
    }
}
