using DotnetEcommerce.Data;
using DotnetEcommerce.Entities;

namespace DotnetEcommerce.Services;

public class AdressService:GenericRepository<Adress>
{
    private readonly AppDbContext dbContext;

    public AdressService(AppDbContext dbContext):base(dbContext) => this.dbContext = dbContext;

}