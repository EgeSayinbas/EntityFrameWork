using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblTasiyici
{
    public string Tasiyicikod { get; set; } = null!;

    public string Kodaciklama { get; set; } = null!;

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
