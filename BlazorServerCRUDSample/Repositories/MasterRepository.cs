using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;


namespace BlazorServerCRUDSample.Repositories
{
    public class MasterRepository<TEntity> : IMasterRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _context;

        public MasterRepository(DbContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public TEntity Get(int id)
        {
            return _context.Set<TEntity>().Find(id)!;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }
    }
}
