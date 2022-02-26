using BlazorServerCRUDSample.Data.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerCRUDSample.Repositories
{
    public class UserRepositoryDapper : IUserRepository
    {
        private string _connectionString;

        public UserRepositoryDapper()
        {
            _connectionString = AppSettings.Configuration.GetConnectionString("DefaultConnection");
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
    }
}
