namespace WorkShop1_WebApp.Models
{
    public class EfProductRepository : IProductRepository
    {
        private readonly StoreDbContext storeDbContext;

        public EfProductRepository(StoreDbContext storeDbContext)
        {
            this.storeDbContext = storeDbContext;
        }

        public List<Product> GetAll()
        {
            return storeDbContext.Products.ToList();
        }
    }
}
