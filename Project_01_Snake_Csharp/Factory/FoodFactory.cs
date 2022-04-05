using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01_Snake_Csharp.Factory
{
    public static class FoodFactory
    {
        private static Random _random = new Random();

        public static Point GetRandomFood(int spaceWidth, int spaceHeight, char symbol)
        {
            spaceWidth = _random.Next(3, spaceWidth - 3);
            spaceHeight = _random.Next(3, spaceHeight - 3);

            return new Point(spaceWidth, spaceHeight, symbol);
        }
    }
}
