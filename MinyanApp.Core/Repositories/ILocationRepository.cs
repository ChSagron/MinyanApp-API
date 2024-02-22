using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinyanApp.Core.Repositories
{
    public interface ILocationRepository
    {
        void SetDistance(int id, double distanse);
    }
}
