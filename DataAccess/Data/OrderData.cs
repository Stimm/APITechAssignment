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
        _db.LoadData<OrderModel, dynamic>("dbo.spOrder_GetAll", new { });

    public async Task<OrderModel?> GetOrder(int orderId)
    {
        var results = await _db.LoadData<OrderModel, dynamic>("dbo.spOrder_Get", new { OrderId = orderId });
        return results.FirstOrDefault();
    }

    public Task InsertOrder(OrderModel order) =>
        _db.SaveData("dbo.spOrder_Insert", new { order.ProductId, order.TypeId, order.Description });

    public Task DeleteOrder(int orderId) =>
        _db.SaveData("dbo.spOrder_Delete", new { OrderId = orderId });

}
