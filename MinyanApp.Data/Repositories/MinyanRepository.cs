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
    public class MinyanRepository : IMinyanRepository
    {
        private readonly DataContext _context;
        public MinyanRepository(DataContext context)
        {
            _context = context;
        }


        public IEnumerable<Minyan> GetAll()
        {
            return _context.Minyans.Include(m => m.Synagogue);
        }

        public Minyan AddItem(Minyan minyan)
        {
            _context.Minyans.Add(minyan);
            _context.SaveChanges();
            return minyan;

        }

    }
}
