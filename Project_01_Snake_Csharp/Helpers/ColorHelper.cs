using System;

namespace Project_01_Snake_Csharp.Helpers
{
    public static class ColorHelper
    {
        /// <summary>
        /// Get a random color for snake food.
        /// </summary>
        /// <param name="value">The color value</param>
        /// <returns>The random color.</returns>
        public static ConsoleColor GetRandomColor(int value)
        {
            switch (value)
            {
                case 1: return ConsoleColor.Red;
                case 2: return ConsoleColor.Green;
                case 3: return ConsoleColor.DarkRed;
                case 4: return ConsoleColor.Blue;
                case 5: return ConsoleColor.Magenta;
                default: return ConsoleColor.White;
            }
        }

        /// <summary>
        /// Reset color to default.
        /// </summary>
        /// <returns>The default color.</returns>
        public static ConsoleColor ResetColor()
        {
            return ConsoleColor.White;
        }
    }
}
