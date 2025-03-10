using SPX_Clone.Models;

namespace SPX_Clone.Services
{
    public interface IShipperService
    {
        Task<IEnumerable<Shipper>> GetAvailableShippersAsync();
    }
}