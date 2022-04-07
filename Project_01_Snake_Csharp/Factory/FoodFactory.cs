using System;

namespace Project_01_Snake_Csharp.Factory
{
    public static class FoodFactory
    {
        private static Random _random = new Random();

        /// <summary>
        /// Get snake food in a random screen location.
        /// </summary>
        /// <param name="spaceWidth">The width of the area where food should appear.</param>
        /// <param name="spaceHeight">The height of the area where food should appear.</param>
        /// <param name="symbol">The character from which the snake consists.</param>
        /// <returns>Snake food point on the screen.</returns>
        public static Point GetRandomFood(int spaceWidth, int spaceHeight, char symbol)
        {
            spaceWidth = _random.Next(3, spaceWidth - 3);
            spaceHeight = _random.Next(3, spaceHeight - 3);

            return new Point(spaceWidth, spaceHeight, symbol);
        }
    }
}
