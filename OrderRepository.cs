using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OrderService.Data;

namespace OrderService
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderDbContext _ctx;
        private readonly IMapper _mapper;

        public OrderRepository(OrderDbContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            var data = await BaseQuery()
                .ToListAsync();

            return data;
        }

        public async Task<Order> GetByIdAsync(int id)
        {
            var data = await BaseQuery()
                .FirstOrDefaultAsync(x => x.Id == id);

            return data!;
        }

        private IQueryable<Order> BaseQuery()
        {
            return _ctx.Orders
            .Include(x => x.User)
            .Include(x => x.Address)
            .Include(x => x.OrderProducts)
            .ThenInclude(x => x.Product)
            .ThenInclude(x => x!.Category);
        }
    }
}
