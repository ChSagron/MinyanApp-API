using MinyanApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinyanApp.Core.Repositories
{
    public interface ISynagogueRepository
    {
        IEnumerable<Synagogue> GetAll();

        Synagogue GetById(int id);

        Synagogue AddItem(Synagogue synagogue);

        void PutById(int id, Minyan minyan);
    }
}
