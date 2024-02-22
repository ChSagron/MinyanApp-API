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
        IEnumerable<User> GetAll();

        User AddItem(User user);

        User FindUser(string nickname);

    }
}
