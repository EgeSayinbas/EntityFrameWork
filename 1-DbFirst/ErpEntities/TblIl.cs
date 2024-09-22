using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblIl
{
    public string Ulkekod { get; set; } = null!;

    public string Ilkod { get; set; } = null!;

    public string Ilad { get; set; } = null!;

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
