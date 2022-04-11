using Meo.Pesquisa.Domain.Interfaces.Repository;
using System;

namespace Meo.Pesquisa.Domain.Entities
{
    public abstract class EntityBase
    {
        public Guid Id { get; set; }
    }
}
