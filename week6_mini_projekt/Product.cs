// using week6_mini_projekt;

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
    }
}
