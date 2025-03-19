using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LoginWorkWithTheHelpOFDBFirst.Models;

public partial class User
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public bool? IsActive { get; set; }
}
