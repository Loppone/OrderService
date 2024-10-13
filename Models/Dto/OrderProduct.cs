namespace OrderService.Models.Dto
{
    public class OrderProduct
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public int OrderId { get; set; }
    }
}
