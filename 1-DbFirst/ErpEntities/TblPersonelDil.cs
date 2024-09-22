using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblPersonelDil
{
    public long Dilid { get; set; }

    public string Personelkodu { get; set; } = null!;

    public string Dil { get; set; } = null!;

    public string Seviye { get; set; } = null!;

    public string? Yer { get; set; }
}
