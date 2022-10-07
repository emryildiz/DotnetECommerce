using DotnetEcommerce.Entities;

namespace DotnetEcommerce.Data;


public interface IRepository<TEntity> where TEntity : BaseEntity
{
    IQueryable<TEntity> GetAll();

    Task<TEntity> GetById(int id);

    Task Add(TEntity entity);

    Task Update(int id, TEntity entity);

    Task Delete(int id);
}