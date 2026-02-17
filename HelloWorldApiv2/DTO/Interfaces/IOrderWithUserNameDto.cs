namespace HelloWorldApiv2.DTO.Interfaces
{
    public interface IOrderWithUserNameDto
    {
        int Id { get; set; }

        DateTime CreatedAt { get; set; }

        decimal TotalAmount { get; set; }

        string Status { get; set; }

        string UserName { get; set; }
    }
}
