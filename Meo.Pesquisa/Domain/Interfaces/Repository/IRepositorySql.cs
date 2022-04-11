using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Meo.Pesquisa.Domain.Entities;

namespace Meo.Pesquisa.Domain.Interfaces.Repository
{
    public interface IRepositorySql<TEntity> where TEntity : IEntity
    {
        Task<TEntity> Add(TEntity entity);
        Task<TEntity> GetId(Guid id);
        Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>> filtro);
        Task<bool> Update(TEntity entity);
        Task<bool> DeleteId(Guid id);
    }

}
