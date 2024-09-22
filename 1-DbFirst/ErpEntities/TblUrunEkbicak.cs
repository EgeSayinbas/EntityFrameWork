using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblUrunEkbicak
{
    public string Urunkod { get; set; } = null!;

    public string Bicakkodu { get; set; } = null!;

    public short? Bicakek { get; set; }

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
