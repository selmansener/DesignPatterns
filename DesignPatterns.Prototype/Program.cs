using System;

namespace DesignPatterns.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorManager colorManager = new ColorManager();

            // Initialize with standard colors

            colorManager["red"] = new Color(255, 0, 0);
            colorManager["green"] = new Color(0, 255, 0);
            colorManager["blue"] = new Color(0, 0, 255);

            // User adds personalized colors

            colorManager["angry"] = new Color(255, 54, 0);
            colorManager["peace"] = new Color(128, 211, 128);
            colorManager["flame"] = new Color(211, 34, 20);

            // User clones selected colors

            Color color1 = colorManager["red"].Clone() as Color;
            Color color2 = colorManager["peace"].Clone() as Color;
            Color color3 = colorManager["flame"].Clone() as Color;

            Console.WriteLine("Press any key to exit...");
            Console.Read();
        }
    }
}
