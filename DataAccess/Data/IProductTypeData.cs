using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IProductTypeData
    {
        Task<ProductTypeModel?> GetProductType(int typeId);
        Task<IEnumerable<ProductTypeModel>> GetProductTypes();
        Task UpdateProductType(ProductTypeModel productType);
    }
}