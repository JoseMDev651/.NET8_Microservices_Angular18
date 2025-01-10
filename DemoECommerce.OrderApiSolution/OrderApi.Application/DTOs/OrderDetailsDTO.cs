using System.ComponentModel.DataAnnotations;
namespace OrderApi.Application.DTOs
{
    public record OrderDetailsDTO
    (
        [Required] int OrderId,
        [Required] int ProductId,
        [Required] int Client,
        [Required,EmailAddress] string Email
        
}
