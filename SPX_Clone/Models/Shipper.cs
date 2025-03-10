namespace SPX_Clone.Models
{
    public class Shipper
    {
        public string ShipperId { get; set; }  // Mã shipper (ví dụ: TX008)
        public string ShipperName { get; set; }  // Tên shipper (ví dụ: Tai Xe 8)
        public string PhoneNumber { get; set; }  // Số điện thoại của shipper (ví dụ: 0947895997)
        public string VehicleNumber { get; set; }  // Biển số xe của shipper (ví dụ: 52B-53782)
    }
}