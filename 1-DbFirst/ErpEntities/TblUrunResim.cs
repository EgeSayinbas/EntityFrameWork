using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblUrunResim
{
    public long ResimId { get; set; }

    public string Urunkod { get; set; } = null!;

    public string Resim { get; set; } = null!;

    public DateTime Resimtarihi { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
