namespace HelloWorldApiv2.DTO.Interfaces
{
    public interface IOrderDto
    {
        int Id { get; set; }

        DateTime CreatedAt { get; set; }

        decimal TotalAmount { get; set; }

        string Status { get; set; }

        int UserId { get; set; }
    }
}
