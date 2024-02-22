using MinyanApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinyanApp.Core.Services
{
    public interface ISynagogueService
    {
        IEnumerable<Synagogue> GetList();

        Synagogue GetById(int id);

        Synagogue AddItem(Synagogue item);

        void PutById(int id, Minyan minyan);
    }
}
