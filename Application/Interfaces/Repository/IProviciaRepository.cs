﻿using Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repository
{
    public interface IProviciaRepository
    {
        public Task<Provincia> BuscarProviciaPorIdAsync(int provinciaId);
    }
}
