using System;
using System.Collections.Generic;

namespace LoginWorkWithTheHelpOFDBFirst.Models;

public partial class Student
{
    public int Id { get; set; }

    public string StudenName { get; set; } = null!;

    public string FatherName { get; set; } = null!;

    public string StudenGender { get; set; } = null!;

    public long GurdianContactNo { get; set; }

    public string StudenClass { get; set; } = null!;

    public int StudenAge { get; set; }
}
