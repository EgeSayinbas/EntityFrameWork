using System;
using System.Collections.Generic;

namespace NorthwindEntities.SqlServerEntities;

public partial class MusteriView
{
    public string CustomerId { get; set; } = null!;

    public int? Ay { get; set; }

    public decimal? Ciro { get; set; }
}
