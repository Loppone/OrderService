using GenericService;
using OrderService.Models.Business;
using OrderService.Models.Data;

public class OrderMappingBusinessProfile : GenericMappingProfile<OrderService.Models.Business.Order, OrderService.Models.Data.Order>
{
    public OrderMappingBusinessProfile()
    {
        CreateMap<OrderService.Models.Data.Order, OrderService.Models.Business.Order>()
            .ForMember(d => d.OrderProducts, opt => opt.MapFrom(s => s.OrderProducts))
            .ReverseMap();

        CreateMap<OrderService.Models.Data.OrderProduct, OrderService.Models.Business.OrderProduct>()
            .ForMember(d => d.Product, opt => opt.MapFrom(s => s.Product))
            .ReverseMap();

        CreateMap<OrderService.Models.Data.Product, OrderService.Models.Business.Product>()
            .ForMember(d => d.Category, opt => opt.MapFrom(s => s.Category))
            .ReverseMap();

        CreateMap<OrderService.Models.Data.User, OrderService.Models.Business.User>();
        CreateMap<OrderService.Models.Data.Category, OrderService.Models.Business.Category>();
    }
}
