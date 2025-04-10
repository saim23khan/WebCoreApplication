using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LoginWorkWithTheHelpOFDBFirst.Models;

public partial class User
{
    public int Id { get; set; }
    [Required]
    public string UserName { get; set; } = null!;
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;
    [Required]
    public string Email { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public bool? IsActive { get; set; }
}
