using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblPersonelSaglik
{
    public long Saglikid { get; set; }

    public string Personelkodu { get; set; } = null!;

    public DateTime Tarih { get; set; }

    public string Rahatsizlik { get; set; } = null!;

    public string Bulgu { get; set; } = null!;

    public string Tani { get; set; } = null!;

    public string Tedavi { get; set; } = null!;
}
