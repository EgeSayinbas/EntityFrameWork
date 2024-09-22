using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblBaskiTip
{
    public string Baskitipkod { get; set; } = null!;

    public string Kodaciklama { get; set; } = null!;

    public double Klisefiyat { get; set; }

    public string Klisedovizkod { get; set; } = null!;

    public string Klisefiyatbirim { get; set; } = null!;

    public double Boyayogunlugu { get; set; }

    public double Boyafiyat { get; set; }

    public string Boyadovizkod { get; set; } = null!;

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string? Ek3 { get; set; }

    public string? Ek4 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
