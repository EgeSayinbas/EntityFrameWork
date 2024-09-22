using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblMaliyetLf
{
    public long Maliyetlfid { get; set; }

    public long Maliyetkodu { get; set; }

    public double Lf { get; set; }

    public double Aramesafe { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
