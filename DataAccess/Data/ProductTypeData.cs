using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data;

public class ProductTypeData : IProductTypeData
{

    public ISqlDataAccess _db;

    public ProductTypeData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<ProductTypeModel>> GetProductTypes() =>
        _db.LoadData<ProductTypeModel, dynamic>("dbo.spProductType_GetAll", new { });

    public async Task<ProductTypeModel?> GetProductType(int typeId)
    {
        var results = await _db.LoadData<ProductTypeModel, dynamic>("dbo.spProductType_Get", new { TypeId = typeId });
        return results.FirstOrDefault();
    }

    public Task UpdateProductType(ProductTypeModel productType) =>
        _db.SaveData("dbo.spProductType_Update", productType);
}
