// using week6_mini_projekt;

using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace week6_mini_projekt
{
    // Product class with Category, Name and Price used to represent a product.
    internal class Product(string category, string name, float price)
    {
        public string Category { get; set; } = category;
        public  string Name { get; set; } = name;
        public float Price { get; set; } = price;

        // static list of Products. Ment to be filed with all products made by user.
        static public List<Product> Products { get; set; } = [];

        // Show sorted list of all products(Price asending, Category Asending, Name Asending) and with a total sum of price at the end.
        // userSearch is used highlight products that have Name that contains userSearch.
        static public void ShowProducts(string userSearch = "")
        {
            // Sort Products based on price from low to high price then Category then Name in preperation to show it to user.
            var sortedProducts = Products.OrderBy(x => x.Price).ThenBy(x => x.Category).ThenBy(x => x.Name);
            int padRightAmount = 27; // Amount of Right padding used when showing list of products

            Console.WriteLine("Here are all currently made products");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Category".PadRight(padRightAmount) + "Name".PadRight(padRightAmount) + "Price");
            foreach (Product product in sortedProducts) {
                if (userSearch == "")
                {
                    Console.WriteLine(product.Category.PadRight(padRightAmount) + product.Name.PadRight(padRightAmount) + product.Price);
                }
                else
                {
                    if (product.Name.Contains(userSearch))
                    {
                        Display.DisplayColorMsg(product.Category.PadRight(padRightAmount) + product.Name.PadRight(padRightAmount) + product.Price, "blue");
                    }
                    else
                    {
                        Console.WriteLine(product.Category.PadRight(padRightAmount) + product.Name.PadRight(padRightAmount) + product.Price);
                    }
                }
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine("You have a total of " + Products.Count + " products and the total price of all products price is: " + Products.Sum(product => product.Price));
        }
    }
}
