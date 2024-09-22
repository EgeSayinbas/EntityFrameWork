using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblUrunLf
{
    public long Urunlfid { get; set; }

    public string Urunkod { get; set; } = null!;

    public double Lf { get; set; }

    public double Aramesafe { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
