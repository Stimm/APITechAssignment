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

    public async Task<ProductModel?> GetProduct(int productId)
    {
        var results = await _db.LoadData<ProductModel, dynamic>("dbo.spProduct_Get", new { ProductId = productId });
        return results.FirstOrDefault();
    }

    public Task InsertProduct(ProductModel product) =>
        _db.SaveData("dbo.spProduct_Insert", new { product.ProductId, product.TypeId });

    public Task DeleteProduct(int productId) =>
        _db.SaveData("dbo.spProduct_Delete", new { ProductId = productId });


}
