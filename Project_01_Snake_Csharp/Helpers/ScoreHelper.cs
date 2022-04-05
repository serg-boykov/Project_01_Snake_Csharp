using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01_Snake_Csharp.Helpers
{
    public static class ScoreHelper
    {
        public static void GetScore(int score)
        {
            Console.SetCursorPosition(2, 22);
            Console.WriteLine($"Score: {score}");
        }
    }
}
