﻿using MinyanApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinyanApp.Core.Services
{
    public interface IMinyanService
    {
        IEnumerable<Minyan> GetList();

        Minyan AddItem(Minyan minyan);

    }
}
