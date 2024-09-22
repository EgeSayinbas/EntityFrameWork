using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblPersonelIhtiyac
{
    public string Personelkodu { get; set; } = null!;

    public string? Ihtiyac { get; set; }

    public string? Planlama { get; set; }

    public DateTime? Tarih { get; set; }
}
