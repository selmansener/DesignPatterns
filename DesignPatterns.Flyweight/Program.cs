using System;

namespace DesignPatterns.Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build a document with text
            string document = "AAZZBBZB";
            char[] chars = document.ToCharArray();

            CharacterFactory factory = new CharacterFactory();

            // extrinsic state
            int pointSize = 10;

            // For each character use a flyweight object
            foreach (char c in chars)
            {
                pointSize++;
                Character character = factory.GetCharacter(c);
                character.Display(pointSize);
            }

            Console.WriteLine("Press any key to exit...");
            Console.Read();
        }
    }
}
