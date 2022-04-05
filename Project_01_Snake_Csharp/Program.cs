using System;
using System.Threading;
using Project_01_Snake_Csharp.Enums;
using Project_01_Snake_Csharp.Factory;
using Project_01_Snake_Csharp.Helpers;
using Project_01_Snake_Csharp.Installers;
using Project_01_Snake_Csharp.Lines;
using Project_01_Snake_Csharp.UI;

namespace Project_01_Snake_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            UIService uiService = new UIService();
            uiService.GetMenu();

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                uiService.GetCommand(key.Key);
            }
        }
    }
}
