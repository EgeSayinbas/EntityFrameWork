using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblRandevu
{
    public long Randevuno { get; set; }

    public long Gorid { get; set; }

    public string Firmakod { get; set; } = null!;

    public DateTime Randevutarihi { get; set; }

    public string BasSaat { get; set; } = null!;

    public string Personelkodu { get; set; } = null!;

    public string? Sure { get; set; }

    public string RandevuSaat { get; set; } = null!;

    public int Gorusmeno { get; set; }

    public string? Bilgi { get; set; }

    public string Gorusmetipno { get; set; } = null!;

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string? Ek3 { get; set; }

    public string? Ek4 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
