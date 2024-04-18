using System.ComponentModel.DataAnnotations;

public class Users
{

    public int UserID { get; set; }

    [Required]
    [StringLength(255)]
    public required string LastName { get; set; }

    [Required]
    [StringLength(255)]
    public required string FirstName { get; set; }

    [StringLength(255)]
    public required string Address { get; set; }

    [StringLength(255)]
    public required string City { get; set; }

    [Required]
    [EmailAddress]
    [StringLength(255)]
    public required string Email { get; set; }

    [Required]
    [StringLength(255)]
    public required string Password {get; set;}
}

