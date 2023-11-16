using System;
using System.Collections.Generic;

namespace NewProject.DataAccess.Models;

public partial class Region
{
    public long Id { get; set; }

    public string City { get; set; } = null!;

    public string? Remark { get; set; }

    public virtual ICollection<Salesman> SalesmanEmployeeNumbers { get; set; } = new List<Salesman>();
}
