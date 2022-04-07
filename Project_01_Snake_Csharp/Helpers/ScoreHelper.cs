using System;

namespace Project_01_Snake_Csharp.Helpers
{
    public static class ScoreHelper
    {
        /// <summary>
        /// Print the user score on screen.
        /// </summary>
        /// <param name="score">The current user score.</param>
        public static void GetScore(int score)
        {
            Console.SetCursorPosition(2, 22);
            Console.WriteLine($"Score: {score}");
        }
    }
}
