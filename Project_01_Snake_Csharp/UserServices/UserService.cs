using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01_Snake_Csharp.UserServices
{
    public class UserService
    {
        private List<User> _users;

        public UserService()
        {
            _users = UserInitializer.GetSampleUserData();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _users.OrderByDescending(x => x.Score);
        }

        public User CreateUser(string name)
        {
            User user = new User();

            var existUser = _users.Select(x => x.Name);

            try
            {
                if (name == "")
                {
                    throw new ArgumentException("Name is empty");
                }

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

            _users.Add(user);

            return user;
        }

        internal void SaveScore(User user)
        {
            if (user.Name == null)
            {
                return;
            }

            _users.Add(user);
        }
    }
}
