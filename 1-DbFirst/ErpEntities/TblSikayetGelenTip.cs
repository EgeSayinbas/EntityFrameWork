using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblSikayetGelenTip
{
    public string Sikayetgelenkod { get; set; } = null!;

    public string? Tipkod { get; set; }

    public string? Kodaciklama { get; set; }

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
