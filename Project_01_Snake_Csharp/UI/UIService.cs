using Project_01_Snake_Csharp.UserServices;
using System;

namespace Project_01_Snake_Csharp.UI
{
    public class UIService
    {
        private GamePlay _gamePlay = new GamePlay();

        private UserService _userService = new UserService();

        private User _user = new User();

        /// <summary>
        /// Calling the Main Menu of the game.
        /// </summary>
        public void GetMenu()
        {
            Console.Clear();
            Console.SetCursorPosition(30, 5);
            Console.WriteLine("||==================================================================||");
            Console.SetCursorPosition(30, 6);
            Console.WriteLine("||------------------------------------------------------------------||");
            Console.SetCursorPosition(30, 7);
            Console.WriteLine("||------------------- Welcome to Snake Game ------------------------||");
            Console.SetCursorPosition(30, 8);
            Console.WriteLine("||------------------------------------------------------------------||");
            Console.SetCursorPosition(30, 9);
            Console.WriteLine("||==================================================================||");
            Console.SetCursorPosition(30, 11);
            Console.WriteLine("                   - Press Enter to Start The Game                    ");
            Console.SetCursorPosition(30, 13);
            Console.WriteLine("                   - Press Arrows to Move The Snake                   ");
            Console.SetCursorPosition(30, 14);
            Console.WriteLine("                   - Press C to Create New User                       ");
            Console.SetCursorPosition(30, 15);
            Console.WriteLine("                   - Press S to Get All Scores                        ");
            Console.SetCursorPosition(30, 16);
            Console.WriteLine("                   - Press ESC to Quit The Game                       ");
            Console.SetCursorPosition(30, 17);
            Console.WriteLine("||------------------------------------------------------------------||");
            Console.SetCursorPosition(30, 18);
            Console.WriteLine("||==================================================================||");
        }

        /// <summary>
        /// The commands of the Main Menu of the game.
        /// </summary>
        /// <param name="key">The pressed console key</param>
        public void GetCommand(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.Enter:
                    StartGame();
                    break;
                case ConsoleKey.C:
                    CreateUserForm();
                    break;
                case ConsoleKey.S:
                    ScoreBoard();
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
                default:
                    GetMenu();
                    break;
            }
        }

        /// <summary>
        /// Run the game.
        /// </summary>
        private void StartGame()
        {
            Console.Clear();
            _gamePlay.StartGame(_user);
            Concede();
        }

        /// <summary>
        /// Create New User.
        /// </summary>
        private void CreateUserForm()
        {
            Console.Clear();
            Console.WriteLine("Create User Form\n");

        Label:
            Console.Write("Enter youe name, please: ");
            string userName = Console.ReadLine();

            try
            {
                _user = _userService.CreateUser(userName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Label;
            }

            Console.WriteLine("\nThe User was saved");
            Console.WriteLine("Press BackSpace to Back");
        }

        /// <summary>
        /// Print the results of the game.
        /// </summary>
        private void ScoreBoard()
        {
            Console.Clear();
            Console.WriteLine("Score Board\n");

            var users = _userService.GetAllUsers();

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Name} with score: {user.Score}");
            }

            Console.WriteLine("\nPress BackSpace to Back");
        }

        /// <summary>
        /// Game Over.
        /// </summary>
        private void Concede()
        {
            Console.Clear();
            Console.WriteLine("Game Over...");
            Console.WriteLine("To Try Again Press Enter...");
            Console.WriteLine("Back to Menu Press BackSpace...");
        }
    }
}
