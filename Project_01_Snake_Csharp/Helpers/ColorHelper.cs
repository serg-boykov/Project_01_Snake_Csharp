using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01_Snake_Csharp.Helpers
{
    public static class ColorHelper
    {
        public static ConsoleColor GetRandomColor(int value)
        {
            switch (value)
            {
                case 1:  return ConsoleColor.Red;
                case 2:  return ConsoleColor.Green;
                case 3:  return ConsoleColor.DarkRed;
                case 4:  return ConsoleColor.Blue;
                case 5:  return ConsoleColor.Magenta;
                default: return ConsoleColor.White;
            }
        }

        public static ConsoleColor ResetColor()
        {
            return ConsoleColor.White;
        }
    }
}
