using System;
using System.Collections.Generic;

namespace _1_DbFirst.MySakila;

public partial class SalesByStore
{
    public string? Store { get; set; }

    public string? Manager { get; set; }

    public decimal? TotalSales { get; set; }
}
