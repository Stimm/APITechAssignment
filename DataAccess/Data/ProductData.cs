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
        _db.LoadData<ProductModel, dynamic>("spProduct_GetAll.sql", new { });

    public async Task<ProductModel?> GetProduct(int productId)
    {
        var results = await _db.LoadData<ProductModel, dynamic>("spProduct_GetAll.sql", new { ProductId = productId });
        return results.FirstOrDefault();
    }

    public Task InsertProduct(ProductModel product) =>
        _db.SaveData("spOrder_Insert.sql", new { product.ProductId, product.TypeId });

    public Task DeleteProduct(int productId) =>
        _db.SaveData("spProduct_Delete.sql", new { ProductId = productId });


}
