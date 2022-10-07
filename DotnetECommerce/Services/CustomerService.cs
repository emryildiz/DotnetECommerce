using DotnetEcommerce.Data;
using DotnetEcommerce.Entities;

namespace DotnetEcommerce.Services;

public class CustomerService:GenericRepository<Customer>
{
    private readonly AppDbContext dbContext;

    public CustomerService(AppDbContext dbContext):base(dbContext) => this.dbContext = dbContext;

}