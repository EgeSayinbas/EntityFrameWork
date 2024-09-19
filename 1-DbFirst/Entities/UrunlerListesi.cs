using System;
using System.Collections.Generic;

namespace _1_DbFirst.Entities;

public partial class UrunlerListesi
{
    public string ProductName { get; set; } = null!;

    public string CategoryName { get; set; } = null!;

    public string CompanyName { get; set; } = null!;
}
