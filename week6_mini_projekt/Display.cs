namespace week6_mini_projekt
{
    public static class Display
    {
        public static void DisplayColorMsg(string msg, string color)
        {
            // red is ment to be used misstake, ex something did not validate.
            if (color == "red")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(msg);
                Console.ResetColor();
            }

            // green is ment to be used to indicate something was done successfully.
            else if (color == "green")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(msg);
                Console.ResetColor();
            }
            // yellow is ment for testing i shall not show up in public version unless something went wrong.
            else if (color == "yellow")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(msg);
                Console.ResetColor();
            }
            // If color is none above then give feedback that this color is not supported
            else
            {
                DisplayColorMsg("ERROR: Do not support color: " + color, "yellow");
            }
        }
    }
}
