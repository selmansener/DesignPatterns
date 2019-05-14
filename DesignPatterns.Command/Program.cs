﻿using System;

namespace DesignPatterns.Command
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create user and let her compute
            User user = new User();

            // User presses calculator buttons
            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            // Undo 4 commands
            user.Undo(4);

            // Redo 3 commands
            user.Redo(3);

            Console.WriteLine("Press any key to exit...");
            Console.Read();
        }
    }
}
