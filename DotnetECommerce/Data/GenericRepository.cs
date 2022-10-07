using DotnetEcommerce.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotnetEcommerce.Data;

public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
    private readonly AppDbContext dbContext;

    public GenericRepository(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task Add(TEntity entity)
    {
        await this.dbContext.Set<TEntity>()
                            .AddAsync(entity);
        await dbContext.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        var entity = await this.GetById(id);

        this.dbContext.Set<TEntity>().Remove(entity);
        await this.dbContext.SaveChangesAsync();
    }

    public IQueryable<TEntity> GetAll()
    {
        return this.dbContext.Set<TEntity>()
                             .AsNoTracking();
    }

    public async Task<TEntity> GetById(int id)
    {
        return await this.dbContext.Set<TEntity>()
                                   .AsNoTracking()
                                   .FirstOrDefaultAsync(x => x.ID == id);
    }

    public async Task Update(int id, TEntity entity)
    {
        this.dbContext.Set<TEntity>().Update(entity);
        await this.dbContext.SaveChangesAsync();
    }
}