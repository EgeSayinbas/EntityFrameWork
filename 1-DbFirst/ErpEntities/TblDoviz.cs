using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblDoviz
{
    public string Dovizkod { get; set; } = null!;

    public string Dovizaciklama { get; set; } = null!;

    public string Dovizsimge { get; set; } = null!;

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
