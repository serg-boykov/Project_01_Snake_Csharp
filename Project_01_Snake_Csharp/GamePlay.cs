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

            // Create the snake's food.
            Point food = FoodFactory.GetRandomFood(119, 20, '+');
            Console.ForegroundColor = ColorHelper.GetRandomColor(new Random().Next(1, 5));
            food.DrawPoint();
            Console.ForegroundColor = ColorHelper.ResetColor(); //or as: Console.ResetColor();

            // Create the snake.
            Snake snake = new Snake();
            snake.CreateSnake(5, new Point(5, 5, 'Z'), DirectionEnum.Right);
            snake.DrawLine();

            // Initialization of the game's score.
            ScoreHelper.GetScore(score);

            while (true)
            {
                // If the collision occurs then exit the game.
                if (line.Collision(snake) || snake.CollisionWithOwnTail())
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
