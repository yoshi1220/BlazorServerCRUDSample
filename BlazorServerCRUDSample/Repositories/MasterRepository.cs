using AutoMapper;
using Microsoft.EntityFrameworkCore;


namespace BlazorServerCRUDSample.Repositories
{
    public class MasterRepository<TEntity> : IMasterRepository<TEntity> where TEntity : class
    {

        private readonly ILogger<IMasterRepository<TEntity>> _logger;

        protected readonly DbContext _context;
        protected readonly IMapper _mapper;
        public MasterRepository(DbContext context, ILogger<IMasterRepository<TEntity>> logger)
        {
            _context = context;
            _logger = logger;

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
            //_context.SaveChangesAsync() //非同期処理の場合はこちらを利用した実装に変更してください。
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
            //_context.SaveChangesAsync() //非同期処理の場合はこちらを利用した実装に変更してください。
        }

        public void Update(TEntity entity, int id)
        {
            var entry = _context.Set<TEntity>().Find(id);

            _mapper.Map(entity, entry);

            try
            {
                _context.SaveChanges();
                //_context.SaveChangesAsync() //非同期処理の場合はこちらを利用した実装に変更してください。
            }
            catch (DbUpdateConcurrencyException ex)
            {
                _logger.LogError(ex, ex.Message); // ログ出力等をここで実装
                throw;
            }

        }
    }
}
