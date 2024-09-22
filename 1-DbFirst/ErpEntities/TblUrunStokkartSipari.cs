using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblUrunStokkartSipari
{
    public string Stokkod { get; set; } = null!;

    public int Siparisno { get; set; }

    public double Miktar1 { get; set; }

    public double? Miktar2 { get; set; }

    public double Netmiktar { get; set; }

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string? Ek3 { get; set; }

    public string? Ek4 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
