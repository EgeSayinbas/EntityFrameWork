using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblUrunKk
{
    public string Urunkod { get; set; } = null!;

    public short Sira { get; set; }

    public short Iccap { get; set; }

    public short Discap { get; set; }

    public int Bobindeadet { get; set; }

    public string Bobindebirim { get; set; } = null!;

    public string Akisyonu { get; set; } = null!;

    public short Musteriyyadet { get; set; }

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
