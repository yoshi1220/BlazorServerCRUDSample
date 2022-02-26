using BlazorServerCRUDSample.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerCRUDSample.Repositories
{
    /// <summary>
    /// マスターメンテ用Repositoryインターフェイス
    /// </summary>
    /// <typeparam name="TEntity">モデルを指定する</typeparam>
    public interface IUserRepository : IMasterRepository<User>
    {

    }
}
