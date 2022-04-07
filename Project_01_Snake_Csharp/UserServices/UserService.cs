using System;
using System.Collections.Generic;
using System.Linq;

namespace Project_01_Snake_Csharp.UserServices
{
    public class UserService
    {
        private List<User> _users;

        /// <summary>
        /// Initialization of the user's list.
        /// </summary>
        public UserService()
        {
            _users = UserInitializer.GetSampleUserData();
        }

        /// <summary>
        /// Getting the sorted list of users by results.
        /// </summary>
        /// <returns>The sorted list of users by results.</returns>
        public IEnumerable<User> GetAllUsers()
        {
            return _users.OrderByDescending(x => x.Score);
        }

        /// <summary>
        /// Create the new user
        /// </summary>
        /// <param name="name">The user name</param>
        /// <returns></returns>
        public User CreateUser(string name)
        {
            User user = new User();

            // Selection of users by name.
            var existUser = _users.Select(x => x.Name);

            try
            {
                // If the user name is empty.
                if (name == "")
                {
                    throw new ArgumentException("Name is empty");
                }

                // If the user name exists.
                if (existUser.Contains(name))
                {
                    throw new ArgumentException("The User exists");
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            user.Name = name;

            // Adding the new user to the list.
            _users.Add(user);

            return user;
        }

        /// <summary>
        /// Saving the user's result.
        /// </summary>
        /// <param name="user">The user for saving
        /// the result of the game</param>
        internal void SaveScore(User user)
        {
            if (user.Name == null)
            {
                return;
            }

            // Adding the user to the list.
            _users.Add(user);
        }
    }
}
