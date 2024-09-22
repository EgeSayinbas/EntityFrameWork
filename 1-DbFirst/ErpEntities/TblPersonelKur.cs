using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblPersonelKur
{
    public long Kursid { get; set; }

    public string Personelkodu { get; set; } = null!;

    public string Kursadi { get; set; } = null!;

    public string? Yer { get; set; }

    public string? Sure { get; set; }
}
