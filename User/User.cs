using System.ComponentModel.DataAnnotations;

namespace DinerFlow.User;

public class User
{
    public int Id { get; set; }

    [MaxLength(50)]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
    public string FirstName{ get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
}