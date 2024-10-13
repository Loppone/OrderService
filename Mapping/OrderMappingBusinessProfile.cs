using GenericService;
using OrderService.Models.Business;

public class OrderMappingBusinessProfile : GenericMappingProfile<Order, OrderService.Data.Order>
{
    public OrderMappingBusinessProfile()
    {
        CreateMap<OrderService.Data.Order, OrderService.Models.Business.Order>()
            .ForMember(d => d.OrderProducts, opt => opt.MapFrom(s => s.OrderProducts))
            .ReverseMap();

        CreateMap<OrderService.Data.OrderProduct, OrderService.Models.Business.OrderProduct>()
            .ForMember(d => d.Product, opt => opt.MapFrom(s => s.Product))
            .ReverseMap();

        CreateMap<OrderService.Data.Product, OrderService.Models.Business.Product>()
            .ForMember(d => d.Category, opt => opt.MapFrom(s => s.Category))
            .ReverseMap();

        CreateMap<OrderService.Data.User, OrderService.Models.Business.User>();
        CreateMap<OrderService.Data.Category, OrderService.Models.Business.Category>();
    }
}
