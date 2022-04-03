using System;
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
            LineInstaller line = new LineInstaller();
            line.DrawShape();

            Point point = FoodFactory.GetRandomFood(119, 20, '+');
            Console.ForegroundColor = ColorHelper.GetRandomColor(new Random().Next(1, 5));
            point.DrawPoint();
            Console.ForegroundColor = ColorHelper.ResetColor();
            //Console.ResetColor(); // как вариант

            Snake snake = new Snake();
            snake.CreateSnake(5, new Point(5, 5, 'Z'), DirectionEnum.Right);
            snake.DrawLine();

            Console.ReadKey();
        }
    }
}
