using BlazorServerCRUDSample.Data;
using BlazorServerCRUDSample.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerCRUDSample.Repositories
{

    public class UserRepository : MasterRepository<User>, IUserRepository
    {
        public UserRepository(SampleDbContext context)
            : base(context)
        {

        }

        public SampleDbContext SampleDbContext
        {
            get { return _context as SampleDbContext; }
        }
    }
}
