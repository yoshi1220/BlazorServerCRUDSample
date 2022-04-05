using AutoMapper;
using Microsoft.EntityFrameworkCore;


namespace BlazorServerCRUDSample.Repositories
{
    public class MasterRepository<TEntity> : IMasterRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _context;
        protected readonly IMapper _mapper;
        public MasterRepository(DbContext context)
        {
            _context = context;

            // Mapするモデルの設定
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TEntity, TEntity>();
            });

            // Mapperを作成
            _mapper = config.CreateMapper();
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

        public void Update(TEntity entity, int id)
        {
            var entry = _context.Set<TEntity>().Find(id);

            _mapper.Map(entity, entry);

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                Console.WriteLine(ex.ToString()); //ログ出力等をここで実装
                throw;
            }

        }
    }
}
