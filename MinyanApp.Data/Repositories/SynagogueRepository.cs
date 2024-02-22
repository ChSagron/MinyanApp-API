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
    public class SynagogueRepository : ISynagogueRepository
    {
        private readonly DataContext _context;

        public SynagogueRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Synagogue> GetAll()
        {
            return _context.Synagogues.Include(s => s.Location).Include(s => s.Minyans).Include(s => s.Users);
        }

        public Synagogue GetById(int id)
        {
            //_context.Synagogues.Include(s => s.Location).Include(s => s.Minyans).Include(s => s.Users).ToList().Find(s => s.Id == id);
            return _context.Synagogues
                    .Where(s => s.Id == id)
                    .Include(s => s.Location)
                    .Include(s => s.Minyans)
                    .Include(s => s.Users)
                    .FirstOrDefault();
        }

        public Synagogue AddItem(Synagogue synagogue)
        {
            _context.Synagogues.Add(synagogue);
            _context.SaveChanges();
            return synagogue;
        }

        //public void PutById(int id, Minyan minyan)
        //{
        //    _context.Synagogues.Find(id).Minyans.Add(minyan);
        //    _context.SaveChanges();
        //}

        public void PutById(int id, Minyan minyan)
        {
            if (minyan == null)
            {
                throw new ArgumentNullException(nameof(minyan), "Minyan cannot be null.");
            }

            var synagogue = _context.Synagogues.FirstOrDefault(s => s.Id == id);

            if (synagogue == null)
            {
                throw new ArgumentException($"Synagogue with id {id} not found.", nameof(id));
            }

            synagogue.Minyans.Add(minyan);

            _context.SaveChanges();
        }


    }
}
