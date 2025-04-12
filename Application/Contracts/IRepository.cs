using OweWay.Domain.Entities;
using System.Collections.Generic;

namespace OweWay.Application.Contracts
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity record);
        void Update(TEntity record);
        void Delete(int id);
    }
}
