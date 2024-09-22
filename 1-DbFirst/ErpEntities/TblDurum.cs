using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblDurum
{
    public string Durumkod { get; set; } = null!;

    public string? Kodaciklama { get; set; }

    public bool? Kullanimda { get; set; }

    public bool? Sipariste { get; set; }

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
