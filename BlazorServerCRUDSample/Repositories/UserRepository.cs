using BlazorServerCRUDSample.Data;
using BlazorServerCRUDSample.Data.Models;

namespace BlazorServerCRUDSample.Repositories
{

    public class UserRepository : MasterRepository<User>, IUserRepository
    {
        public UserRepository(SampleDbContext context, ILogger<UserRepository> logger)
            : base(context, logger)
        {

        }

        public SampleDbContext SampleDbContext
        {
            get { return _context as SampleDbContext; }
        }


    }
}
