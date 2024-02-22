using MinyanApp.Core.Entities;
using MinyanApp.Core.Repositories;
using MinyanApp.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinyanApp.Service
{
    public class SynagogueService : ISynagogueService
    {
        private readonly ISynagogueRepository _synagogueRepository;

        public SynagogueService(ISynagogueRepository synagogueRepository)
        {
            _synagogueRepository = synagogueRepository;
        }

        public IEnumerable<Synagogue> GetList()
        {
            return _synagogueRepository.GetAll();
        }

        public Synagogue GetById(int id)
        {
            return _synagogueRepository.GetById(id);
        }

        public Synagogue AddItem(Synagogue item)
        {
            return _synagogueRepository.AddItem(item);
        }

        public void PutById(int id, Minyan minyan) 
        {
            _synagogueRepository.PutById(id, minyan);
        }

        //public Synagogue SetToUser(int userId , Synagogue synagogue)
        //{
        //    _synagogueRepository.Get
        //}

    }
}
