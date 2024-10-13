using OrderService.Models.Business;

namespace OrderService
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetAllAsync();
        Task<Order> GetByIdAsync(int id);
    }
}
