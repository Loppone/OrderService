using GenericService;

public class OrderMappingDtoProfile : GenericMappingProfile<OrderService.Models.Dto.Order, OrderService.Models.Business.Order>
{
    public OrderMappingDtoProfile()
    {
        CreateMap<OrderService.Models.Dto.Order, OrderService.Models.Business.Order>()
        .ForMember(d => d.OrderProducts, opt => opt.MapFrom(s =>
            s.OrderProducts.Select(x => new OrderService.Models.Business.OrderProduct
            {
                ProductId = x.ProductId,
                Quantity = x.Quantity
            })))
        .ReverseMap();
    }
}
