using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblPersonelIslem
{
    public long PerIslemId { get; set; }

    public long TakipId { get; set; }

    public string Personelkodu { get; set; } = null!;

    public string Islemkod { get; set; } = null!;

    public string Islemtipkod { get; set; } = null!;
}
