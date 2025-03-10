namespace SPX_Clone.Models
{
    public class AssignOrderViewModel
    {
        public Order Order { get; set; }
        public IEnumerable<Shipper> Shippers { get; set; }
    }
}