using Project_01_Snake_Csharp.Enums;
using Project_01_Snake_Csharp.Factory;
using Project_01_Snake_Csharp.Helpers;
using Project_01_Snake_Csharp.Installers;
using Project_01_Snake_Csharp.UserServices;
using System;
using System.Threading;

namespace Project_01_Snake_Csharp
{
    public class GamePlay
    {
        private UserService _userService = new UserService();

        /// <summary>
        /// Run the game.
        /// </summary>
        /// <param name="user">The current user</param>
        public void StartGame(User user)
        {
            if (user == null)
            {
                user = new User();
            }

            int score = 0;

            LineInstaller line = new LineInstaller();
            line.DrawShape();

            // Create the snake food.
            int spaceWidth = 119, spaceHeight = 20;
            char symbolFood = '+';
            Point food = FoodFactory.GetRandomFood(spaceWidth, spaceHeight, symbolFood);
            int minValue = 1, maxValue = 5;
            Console.ForegroundColor = ColorHelper.GetRandomColor(new Random().Next(minValue, maxValue));
            food.DrawPoint();
            Console.ForegroundColor = ColorHelper.ResetColor(); //or as: Console.ResetColor();

            // Create the snake.
            Snake snake = new Snake();
            int length = 5, left = 5, top = 5;
            char symbolSnake = 'Z';
            snake.CreateSnake(length, new Point(left, top, symbolSnake), DirectionType.Right);
            snake.DrawLine();

            // Initialization of the game's score.
            ScoreHelper.GetScore(score);

            while (true)
            {
                // If the collision occurs then exit the game.
                var isCollision = line.Collision(snake) || snake.CollisionWithOwnTail();
                if (isCollision)
                {
                    break;
                }

                // If the snake ate food then we increase the score and create a new food in random order.
                if (snake.Eat(food))
                {
                    score++;
                    ScoreHelper.GetScore(score);

                    food = FoodFactory.GetRandomFood(119, 20, '+');
                    Console.ForegroundColor = ColorHelper.GetRandomColor(new Random().Next(1, 5));
                    food.DrawPoint();
                    Console.ForegroundColor = ColorHelper.ResetColor();
                }

                // Tracking keystrokes.
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.PressKey(key.Key);
                }

                // Move the snake.
                snake.Move();
                Thread.Sleep(100);
            }

            // Saving the user's game result.
            user.Score = score;
            _userService.SaveScore(user);
        }
    }
}
