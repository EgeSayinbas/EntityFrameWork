using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblVardiyaUrunDetay
{
    public int Vardiyano { get; set; }

    public int Vardiyaaltno { get; set; }

    public string Urunkod { get; set; } = null!;

    public string Stokkod { get; set; } = null!;

    public int Hareketno { get; set; }

    public double Kullanilanmiktar1 { get; set; }

    public double Kullanilanmiktar2 { get; set; }

    public double Netkullanilan { get; set; }

    public short Hammaddeenadet { get; set; }

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
