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

        public List<User> GetList()
        {
            return _userRepository.GetAll();
        }

        public User AddItem(User item)
        {
            return _userRepository.AddUser(item);
        }

    }
}
