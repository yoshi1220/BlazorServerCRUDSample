using BlazorServerCRUDSample.Data.Models;

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
