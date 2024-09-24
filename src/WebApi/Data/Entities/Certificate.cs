namespace WebApi.Data.Models
{
    public class Certificate
    {
        public required int Id { get; set; }
        public required int Cost { get; set; }
        public required string BuyerName { get; set; }
        public required string BuyerNumber { get; set; }
        public required string RecipientName { get; set; }
        public required string RecipientNumber { get; set; }
    }
}
