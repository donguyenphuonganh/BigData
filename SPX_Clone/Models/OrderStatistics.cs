namespace SPX_Clone.Models
{
    public class OrderStatistics
    {
        public string TimePeriod { get; set; }   // Thời gian (Ngày, Tuần, Tháng, Quý, Năm)
        public int TotalOrders { get; set; }      // Tổng số đơn hàng
        public decimal TotalRevenue { get; set; } // Tổng doanh thu (ví dụ)
    }
}