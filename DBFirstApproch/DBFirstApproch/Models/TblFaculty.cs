using System;
using System.Collections.Generic;

namespace DBFirstApproch.Models;

public partial class TblFaculty
{
    public int Id { get; set; }

    public string TeacherName { get; set; } = null!;

    public string FatherHusbundName { get; set; } = null!;

    public long ContactNo { get; set; }

    public string Gender { get; set; } = null!;
}
