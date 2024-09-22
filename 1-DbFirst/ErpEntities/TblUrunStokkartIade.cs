using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblUrunStokkartIade
{
    public int Vardiyano { get; set; }

    public int Vardiyaaltno { get; set; }

    public string Urunkod { get; set; } = null!;

    public string Stokkod { get; set; } = null!;

    public int Hareketno { get; set; }

    public double Iademiktar1 { get; set; }

    public double Iademiktar2 { get; set; }

    public double Netiade { get; set; }

    public bool Iadealindi { get; set; }

    public DateTime? Iadealinditarih { get; set; }

    public bool Etiketbasildi { get; set; }

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
