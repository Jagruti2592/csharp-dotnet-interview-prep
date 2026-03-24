using System.ComponentModel.DataAnnotations;


namespace SmartCommerce.Application.DTOs;

public class CreateUserDto
{
    [Required]
    [MinLength(2)]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }   
}