using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblIlIlce
{
    public string Ulkekod { get; set; } = null!;

    public string Ilkod { get; set; } = null!;

    public string Ilcekod { get; set; } = null!;

    public string? Ilcead { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
