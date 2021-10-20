using Microsoft.EntityFrameworkCore;
using ProgrammersBlog.Shared.Data.Abstract;
using ProgrammersBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Shared.Data.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        private readonly DbContext _context;
        public EfEntityRepositoryBase(DbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
        }

        public async Task <bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().AnyAsync(predicate);
        }

        public async Task <int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().CountAsync(predicate);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await _context.Set<TEntity>().Remove(entity);
        }

        public async Task <IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public async Task <TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
