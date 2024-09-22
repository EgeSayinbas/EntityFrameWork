using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblSiparisKliseAlt
{
    public long Sipariskliseid { get; set; }

    public long Siparisno { get; set; }

    public string Kliseno { get; set; } = null!;

    public string Klisekod { get; set; } = null!;

    public string No { get; set; } = null!;

    public string Revizyonkod { get; set; } = null!;

    public string Baskitipkod { get; set; } = null!;

    public string Klisetipkod { get; set; } = null!;

    public string Makinakodu { get; set; } = null!;

    public string Dislisayisi { get; set; } = null!;

    public short Aaadet { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
