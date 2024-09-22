using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblSaTeklifFiyat
{
    public int Sateklifkod { get; set; }

    public string Sirano { get; set; } = null!;

    public double? Ustmiktar { get; set; }

    public double? Netmiktar { get; set; }

    public double? Altmiktar { get; set; }

    public string? Birimkod { get; set; }

    public double Fiyat { get; set; }

    public string Dovizkod { get; set; } = null!;
}
