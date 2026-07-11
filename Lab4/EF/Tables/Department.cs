using System;
using System.Collections.Generic;

namespace Lab4.EF.Tables;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;

    public string? Location { get; set; }
}
