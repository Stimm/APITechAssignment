using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IOrderData
    {
        ISqlDataAccess _db { get; }

        Task DeleteOrder(int orderId);
        Task<OrderModel?> GetOrder(int orderId);
        Task<IEnumerable<OrderModel>> GetOrders();
        Task InsertOrder(OrderModel order);
    }
}