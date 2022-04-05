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
            int score = 0;
            
            LineInstaller line = new LineInstaller();
            line.DrawShape();

            Point food = FoodFactory.GetRandomFood(119, 20, '+');
            Console.ForegroundColor = ColorHelper.GetRandomColor(new Random().Next(1, 5));
            food.DrawPoint();
            Console.ForegroundColor = ColorHelper.ResetColor();
            //Console.ResetColor(); // как вариант

            Snake snake = new Snake();
            snake.CreateSnake(5, new Point(5, 5, 'Z'), DirectionEnum.Right);
            snake.DrawLine();

            ScoreHelper.GetScore(score);

            while (true)
            {
                if (line.Collision(snake) || snake.CollisionWithOwnTail())
                {
                    break;
                }
                
                if (snake.Eat(food))
                {
                    score++;
                    ScoreHelper.GetScore(score);

                    food = FoodFactory.GetRandomFood(119, 20, '+');
                    Console.ForegroundColor = ColorHelper.GetRandomColor(new Random().Next(1, 5));
                    food.DrawPoint();
                    Console.ForegroundColor = ColorHelper.ResetColor();
                }
                
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.PressKey(key.Key);
                }

                snake.Move();
                Thread.Sleep(200);
            }

            Console.WriteLine("Game Over...");
        }
    }
}
