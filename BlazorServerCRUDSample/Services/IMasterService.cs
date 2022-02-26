using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerCRUDSample.Services
{
    /// <summary>
    /// マスター制御用サービスインターフェース
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IMasterService<TEntity>
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);
        void Remove(TEntity entity);
    }
}
