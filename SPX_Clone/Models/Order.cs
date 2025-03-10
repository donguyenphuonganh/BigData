namespace SPX_Clone.Models
{
    public class Order
    {
        public string OrderId { get; set; }     // Mã đơn hàng
        public string CustomerId { get; set; }  // Mã khách hàng
        public string CustomerName {get;set;}
        public DateTime OrderDate { get; set; } // Ngày đặt hàng
        public decimal TotalAmount { get; set; } // Tổng tiền đơn hàng
        public string Status { get; set; }      // Trạng thái đơn hàng (VD: "Đang chờ", "Đang giao", "Hoàn thành")
    }
}