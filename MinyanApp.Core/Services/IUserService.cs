using MinyanApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinyanApp.Core.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetList();

        User AddItem(User item);
        User FindUser(string nickname, string password);
    }
}
