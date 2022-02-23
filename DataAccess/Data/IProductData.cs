using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IProductData
    {
        Task DeleteProduct(int productId);
        Task<ProductModel?> GetProduct(int productId);
        Task<IEnumerable<ProductModel>> GetProducts();
        Task InsertProduct(ProductModel product);
    }
}