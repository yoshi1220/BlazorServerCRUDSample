using AutoMapper;
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
            _context.SaveChanges();
        }

        public TEntity Get(int id)
        {
            return _context.Set<TEntity>().Find(id)!;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public void Remove(int id)
        {
            var entry = _context.Set<TEntity>().Find(id);
            _context.Set<TEntity>().Remove(entry);
            _context.SaveChanges();
        }

        //public void Update(TEntity entity, int id)
        //{
        //    var entry = _context.Set<TEntity>().Find(id);

        //    // Mapするモデルの設定
        //    var config = new MapperConfiguration(cfg =>
        //    {
        //        cfg.CreateMap<TEntity, TEntity>();
        //    });
        //    // Mapperを作成
        //    var mapper = config.CreateMapper();
        //    // UserViewModelのデータがUserの型でマッピングされる
        //    entry = mapper.Map<TEntity>(entity);

        ////    var entry2 = _context.Entry(entry);
        ////    entry2.State = EntityState.Modified;
        //    _context.SaveChanges();
        //}
    }
}
