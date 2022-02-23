using DataAccess.DbAccess;
using DataAccess.Models;
namespace DataAccess.Data;
public class OrderData : IOrderData
{

    public ISqlDataAccess _db { get; }

    public OrderData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<OrderModel>> GetOrders() =>
        _db.LoadData<OrderModel, dynamic>("spProduct_GetAll.sql", new { });

    public async Task<OrderModel?> GetOrder(int orderId)
    {
        var results = await _db.LoadData<OrderModel, dynamic>("spProduct_GetAll.sql", new { OrderId = orderId });
        return results.FirstOrDefault();
    }

    public Task InsertOrder(OrderModel order) =>
        _db.SaveData("spOrder_Insert.sql", new { order.ProductId, order.TypeId, order.Description });

    public Task DeleteOrder(int orderId) =>
        _db.SaveData("spOrder_Delete.sql", new { OrderId = orderId });

}
