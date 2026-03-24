using System.ComponentModel.DataAnnotations;

namespace SmartCommerce.Application.DTOs;

public class UpdateUserDto
{
    [Required]
    public int Id { get; set; }

    [Required]
    [MinLength(2)]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }
}