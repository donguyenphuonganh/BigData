namespace SPX_Clone.Models
{
    public class ManagerDashboardViewModel
    {
        public int TotalOrders { get; set; }
        public int PendingOrders { get; set; }
        public int InProgressOrders { get; set; }
        public int CompletedOrders { get; set; }
        public List<Order> RecentOrders { get; set; } = new List<Order>(); // Đảm bảo khởi tạo danh sách

        public ManagerDashboardViewModel()
        {
            RecentOrders = new List<Order>();  // Khởi tạo danh sách để tránh lỗi null
        }
    }

}