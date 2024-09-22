using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblAnilox
{
    public string Aniloxkod { get; set; } = null!;

    public string Kodaciklama { get; set; } = null!;

    public string Makinakodu { get; set; } = null!;

    public int Linecm { get; set; }

    public int Lineinch { get; set; }

    public double Volume { get; set; }

    public double Boyaaktarimi { get; set; }

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
