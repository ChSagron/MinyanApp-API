using MinyanApp.Core.Entities;
using MinyanApp.Core.Repositories;
using MinyanApp.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinyanApp.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> GetList()
        {
            return _userRepository.GetAll();
        }

        public User AddItem(User user)
        {
            return _userRepository.AddItem(user);
        }

        public User FindUser(string nickname, string password) 
        {
            User user = _userRepository.FindUser(nickname);
            if(user != null && user.Password == password)
            {
                return user;
            }
            return null;

            //if(user == null)
            //{
            //    return new User() { Id = 20 };

            //}
            //else if (user.Password == pass)
            //{
            //    return user;
            //}
            //return new User() { Id = 200 };
        }


    }
}
