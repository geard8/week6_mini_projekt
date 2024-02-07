namespace week6_mini_projekt
{
    static internal class Utils
    {
        public static Product? UserCreateProduct()
        {
            string newCategory = "";
            string newName = "";
            float newPriceFloat = 0;

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

            Display.DisplayColorMsg("newCategory: " + newCategory, "yellow");
            Display.DisplayColorMsg("newName: " + newName, "yellow");
            Display.DisplayColorMsg("newPriceFloat: " + newPriceFloat, "yellow");

            //TODO NEXT create Product based on user input


            return new Product(newCategory, newName, newPriceFloat);
        }
    }
}
