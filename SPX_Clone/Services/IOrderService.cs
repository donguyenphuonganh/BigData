using SPX_Clone.Models;

namespace SPX_Clone.Services
{
    public interface IOrderService
    {
        Task<int> GetTotalOrdersAsync();
        Task<IEnumerable<Order>> GetOrdersByStatusAsync(string status);  // Đảm bảo kiểu trả về là IEnumerable<DonHang>
        Task<Order> GetOrderByIdAsync(int orderId);
        Task<IEnumerable<Order>> GetRecentOrdersAsync(string searchString);
        Task<OrderStatistics> GetOrderStatisticsAsync(string timePeriod);
        Task AssignOrderToShipper(int orderId, int shipperId);
    }
}