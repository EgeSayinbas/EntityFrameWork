using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblGorusmeTip
{
    public string Gorusmetipno { get; set; } = null!;

    public string Tipaciklama { get; set; } = null!;

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
