using MinyanApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinyanApp.Data.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private readonly DataContext _context;
        public LocationRepository(DataContext context)
        {
            _context = context;
        }

        public void SetDistance(int id, double distanse)
        {
            var s = _context.Synagogues.Find(id);
            s.Location.Distance = distanse;
            _context.SaveChanges();
        }
    }
}
