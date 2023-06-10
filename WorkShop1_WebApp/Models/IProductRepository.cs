namespace WorkShop1_WebApp.Models
{
    public interface IProductRepository
    {
        List<Product> GetAll(int pageNumber,int pageSize); 
    }
}
