using GenericService;

public class OrderMappingBusinessProfile : GenericMappingProfile<OrderService.Models.Business.Order, OrderService.Models.Data.Order>
{
    public OrderMappingBusinessProfile()
    {
        CreateMap<OrderService.Models.Business.Order, OrderService.Models.Data.Order>()
            .ForMember(d => d.OrderProducts, opt => opt.MapFrom(s => s.OrderProducts))
            .ReverseMap();

        CreateMap<OrderService.Models.Business.OrderProduct, OrderService.Models.Data.OrderProduct>()
            .ForMember(d => d.ProductId, opt => opt.MapFrom(s => s.ProductId))
            .ReverseMap();
    }
}
