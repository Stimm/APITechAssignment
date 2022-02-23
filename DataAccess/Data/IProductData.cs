using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IProductData
    {
        Task DeleteProduct(string productId);
        Task<IEnumerable<ProductModel>> GetProductByOrderId(int orderId);
        Task<ProductModel?> GetProduct(string productId);
        Task<IEnumerable<ProductModel>> GetProducts();
        Task UpdateProduct(ProductModel product);
        Task InsertProduct(ProductModel product);
    }
}