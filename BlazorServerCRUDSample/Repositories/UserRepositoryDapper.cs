using BlazorServerCRUDSample.Data.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BlazorServerCRUDSample.Repositories
{
    public class UserRepositoryDapper : IUserRepository
    {
        private string _connectionString;

        public UserRepositoryDapper(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                db.Open();
                return db.Query<User>("SELECT * FROM Users", commandType: CommandType.Text);
            }
        }

        public void Remove(User entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }


        public void Update(User entity)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
