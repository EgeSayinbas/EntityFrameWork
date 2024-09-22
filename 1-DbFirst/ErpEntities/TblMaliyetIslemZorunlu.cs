using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblMaliyetIslemZorunlu
{
    public long MaliyetislemZid { get; set; }

    public int Maliyetkodu { get; set; }

    public string Islemkod { get; set; } = null!;

    public string Islemtipkod { get; set; } = null!;

    public string Makinakodu { get; set; } = null!;
}
