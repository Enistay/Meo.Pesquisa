using Meo.Pesquisa.Domain.Interfaces.Repository;
using Meo.Pesquisa.Infra.Data.Sql;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Meo.Pesquisa.Infra.Data.Repository
{
    public class RepositorySql<TEntity> : IRepositorySql<TEntity>
        where TEntity : class, IEntity
    {
        public SurveyContext _surveyContext { get; set; }
        public RepositorySql(SurveyContext surveyContext) => _surveyContext = surveyContext;

        public async Task<TEntity> Add(TEntity entity)
        {
            await _surveyContext.Set<TEntity>().AddAsync(entity);
            return entity;
        }

        public async Task<TEntity> GetId(Guid id)
        {
            var current = await _surveyContext.Set<TEntity>().FirstOrDefaultAsync(f => f.Id == id);

            return current;
        }

        public async Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>> filter)
        {
            var current = Activator.CreateInstance<TEntity>();
            List<TEntity> lista = new List<TEntity>();
            lista = await _surveyContext.Set<TEntity>().Where(filter).ToListAsync();
            return lista;
        }

        public async Task<bool> Update(TEntity entity)
        {
            var current = await _surveyContext.Set<TEntity>().FirstOrDefaultAsync(f => f.Id == entity.Id);

            current = entity;

            return true;
        }

        public async Task<bool> DeleteId(Guid id)
        {
            var novo = Activator.CreateInstance<TEntity>();

            var current = await _surveyContext.Set<TEntity>().FirstOrDefaultAsync(f => f.Id == id);

            _surveyContext.Set<TEntity>().Remove(current);

            return true;
        }
    }
}
