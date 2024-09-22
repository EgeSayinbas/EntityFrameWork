using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblMakinaBakimHareket
{
    public int Bakimhareketno { get; set; }

    public int Bakimno { get; set; }

    public string Stokkod { get; set; } = null!;

    public string Urunkod { get; set; } = null!;

    public double Miktar { get; set; }

    public double Fiyat { get; set; }
}
