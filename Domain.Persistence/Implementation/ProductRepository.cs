using Domain.Models;
using Domain.Persistence.Contract;

namespace Domain.Persistence.Implementation
{
    public class ProductRepository : GenericRepository<Products>, IProductRepository
    {
        public ProductRepository(DataStoreDbContext dbContext) : base(dbContext)
        {
        }
    }
}
