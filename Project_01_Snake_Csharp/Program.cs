using Project_01_Snake_Csharp.UI;
using System;

namespace Project_01_Snake_Csharp
{
    
    // Game -= Snake =-.

    class Program
    {
        /// <summary>
        /// Application start method.
        /// Application work always starts with this method.
        /// </summary>
        /// <param name="args"> 
        /// Arguments passed as parameters
        /// when calling the application from the console with arguments.
        /// </param>
        static void Main(string[] args)
        {
            // Calling the Main Menu of the game.
            UIService uiService = new UIService();
            uiService.GetMenu();

            while (true)
            {
                // Tracking keystrokes to call the commands
                // of the Main Menu of the game.
                ConsoleKeyInfo key = Console.ReadKey();
                uiService.GetCommand(key.Key);
            }
        }
    }
}
