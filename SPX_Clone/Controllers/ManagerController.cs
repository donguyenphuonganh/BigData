using Microsoft.AspNetCore.Mvc;
using SPX_Clone.Models;

namespace SPX_Clone.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult Index(string searchString)
        {
            var model = new ManagerDashboardViewModel
            {
                TotalOrders = 100,
                PendingOrders = 10,
                InProgressOrders = 5,
                CompletedOrders = 20,
                RecentOrders = new List<Order>
                {
                    new Order { OrderId = "DH0001", CustomerName = "John Doe", Status = "Pending" },
                    new Order { OrderId = "DH0002", CustomerName = "Jane Smith", Status = "In Progress" },
                }
            };

            return View(model);
        }

        public IActionResult Dashboard()
        {
            // Truyền danh sách đơn hàng giả lập vào Dashboard
            var orders = new List<Order>
            {
                new Order { OrderId = "DH0010", CustomerName = "Alice", Status = "Completed" },
                new Order { OrderId = "DH0011", CustomerName = "Bob", Status = "Pending" },
            };

            return View(orders);  // Truyền model vào view
        }

        public IActionResult AssignOrder()
        {
            // Truyền danh sách shipper giả lập
            var shippers = new List<string> { "Shipper 1", "Shipper 2", "Shipper 3" };
            return View(shippers);
        }

        public IActionResult Statistics()
        {
            // Truyền dữ liệu thống kê giả lập
            var statistics = new
            {
                TotalOrders = 200,
                MonthlyRevenue = 50000,
                ActiveShippers = 15
            };

            return View(statistics);
        }
    }
}