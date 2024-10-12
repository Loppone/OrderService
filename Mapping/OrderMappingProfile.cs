using GenericService;

public class OrderMappingProfile : GenericMappingProfile<OrderService.Models.Order, OrderService.Data.Order>
{
    public OrderMappingProfile()
    {
        CreateMap<OrderService.Data.Order, OrderService.Models.Order>()
            .ForMember(d => d.OrderProducts, opt => opt.MapFrom(s => s.OrderProducts))
            .ReverseMap();


        CreateMap<OrderService.Data.OrderProduct, OrderService.Models.OrderProduct>()
            .ForMember(d => d.Product, opt => opt.MapFrom(s => s.Product))
            .ReverseMap();


        CreateMap<OrderService.Data.Product, OrderService.Models.Product>()
            .ForMember(d => d.Category, opt => opt.MapFrom(s => s.Category))
            .ReverseMap()
            ;


        CreateMap<OrderService.Data.User, OrderService.Models.User>();

        CreateMap<OrderService.Data.Category, OrderService.Models.Category>();
    }
}
