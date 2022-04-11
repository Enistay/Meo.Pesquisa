using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meo.Pesquisa.Domain.Interfaces.Repository
{
    public interface IEntity
    {
        public Guid Id { get; set; }
    }
}
