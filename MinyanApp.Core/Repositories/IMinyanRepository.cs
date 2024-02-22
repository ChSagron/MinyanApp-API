using MinyanApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinyanApp.Core.Repositories
{
    public interface IMinyanRepository
    {
        IEnumerable<Minyan> GetAll();

        Minyan AddItem(Minyan minyan);
    }
}
