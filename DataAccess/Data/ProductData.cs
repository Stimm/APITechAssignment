using DataAccess.DbAccess;
using DataAccess.Models;
namespace DataAccess.Data;
public class ProductData : IProductData
{

    public ISqlDataAccess _db;

    public ProductData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<ProductModel>> GetProducts() =>
        _db.LoadData<ProductModel, dynamic>("dbo.spProduct_GetAll", new { });

    public async Task<ProductModel?> GetProduct(string productId)
    {
        var results = await _db.LoadData<ProductModel, dynamic>("dbo.spProduct_Get", new { ProductId = productId });
        return results.FirstOrDefault();
    }

    public Task<IEnumerable<ProductModel>> GetProductByOrderId(int orderId) =>
        _db.LoadData<ProductModel, dynamic>("dbo.spProduct_GetOrderId", new { OrderId = orderId });
 
    public Task InsertProduct(ProductModel product) =>
        _db.SaveData("dbo.spProduct_Insert", new { product.ProductId, product.TypeId });

    public Task UpdateProduct(ProductModel product) =>
        _db.SaveData("dbo.spProduct_Update", product);

    public Task DeleteProduct(string productId) =>
        _db.SaveData("dbo.spProduct_Delete", new { ProductId = productId });
}
