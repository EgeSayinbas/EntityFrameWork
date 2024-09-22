using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblKliseAlt
{
    public string Kliseno { get; set; } = null!;

    public string Klisekod { get; set; } = null!;

    public string No { get; set; } = null!;

    public string Revizyonkod { get; set; } = null!;

    public string Baskitipkod { get; set; } = null!;

    public string Klisetipkod { get; set; } = null!;

    public string? Makinakodu { get; set; }

    public string? Dislisayisi { get; set; }

    public short? Aaadet { get; set; }

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
