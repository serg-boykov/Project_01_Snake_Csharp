using System;
using System.Threading;
using Project_01_Snake_Csharp.Enums;
using Project_01_Snake_Csharp.Factory;
using Project_01_Snake_Csharp.Helpers;
using Project_01_Snake_Csharp.Installers;
using Project_01_Snake_Csharp.Lines;

namespace Project_01_Snake_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            GamePlay gamePlay = new GamePlay();
            gamePlay.StartGame();

            Console.WriteLine("Game Over...");
        }
    }
}
