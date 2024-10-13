using AutoMapper;
using OrderService.Models.Business;

namespace OrderService
{
    public class CustomOrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public CustomOrderService(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            var dataEntity = await _orderRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<Order>>(dataEntity);
        }

        public async Task<Order> GetByIdAsync(int id)
        {
            var dataEntity = await _orderRepository.GetByIdAsync(id);

            return _mapper.Map<Order>(dataEntity);
        }
    }
}
