using MinyanApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinyanApp.Core.Repositories
{
    public interface IUserRepository
    {
        List<User> GetAll();

        User AddUser(User user);

    }
}
