using System;
using System.Collections.Generic;

namespace _1_DbFirst.Entities;

public partial class MusteriView
{
    public string CustomerId { get; set; } = null!;

    public int? Ay { get; set; }

    public decimal? Ciro { get; set; }
}
