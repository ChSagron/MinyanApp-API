using Microsoft.EntityFrameworkCore;
using MinyanApp.Core.Entities;
using MinyanApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinyanApp.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }

        public User AddItem(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }
        public User FindUser(string nickname)
        { 
        //{.ThenInclude(s => s.Location).Include(u => u.Synagogue).ThenInclude(s => s.Minyans).Include(u => u.Synagogue).ThenInclude(s => s.Users)
            return _context.Users.Include(u => u.Synagogue).ThenInclude(s => s.Location).Include(u => u.Synagogue).ThenInclude(s => s.Minyans).Include(u => u.Synagogue).ThenInclude(s => s.Users).FirstOrDefault<User>(u => u.Nickname == nickname);
        }



    }
}
