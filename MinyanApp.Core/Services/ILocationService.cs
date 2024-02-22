using MinyanApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinyanApp.Core.Services
{
    public interface ILocationService
    {
        double CalculateDistance(Location point1, Location point2);
        IEnumerable<Synagogue> GetTop10Synagogue(Location current /*, List<Synagogue> list*/);

    }
}
