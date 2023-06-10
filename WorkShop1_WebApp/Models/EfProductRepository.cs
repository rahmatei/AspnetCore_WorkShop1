namespace WorkShop1_WebApp.Models
{
    public class EfProductRepository : IProductRepository
    {
        private readonly StoreDbContext storeDbContext;

        public EfProductRepository(StoreDbContext storeDbContext)
        {
            this.storeDbContext = storeDbContext;
        }

        public PageData<Product> GetAll(int pageNumber, int pageSize)
        {
            var pageInfo = new PageInfo()
            {
                PageNumber = pageNumber,
                PageSize = pageSize
            };

            var pageData = new PageData<Product>
            {
                pageInfo = pageInfo,
                Data = storeDbContext.Products.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList()
            };

            pageData.pageInfo.TotalCount = storeDbContext.Products.Count();

            return pageData;    
        }
    }
}
