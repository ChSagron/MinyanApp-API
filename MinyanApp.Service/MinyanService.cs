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
    public class MinyanService : IMinyanService
    {

        private readonly IMinyanRepository _minyanRepository;

        public MinyanService(IMinyanRepository minyanRepository)
        {
            _minyanRepository = minyanRepository;
        }

 

        public IEnumerable<Minyan> GetList()
        {
            return _minyanRepository.GetAll();
        }

        public Minyan AddItem(Minyan minyan)
        {
            return _minyanRepository.AddItem(minyan);
        }


    }
}
