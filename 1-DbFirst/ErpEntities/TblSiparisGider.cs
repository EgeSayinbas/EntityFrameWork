using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblSiparisGider
{
    public int Siparisno { get; set; }

    public string Giderkod { get; set; } = null!;

    public string Urunkod { get; set; } = null!;

    public string Makinakodu { get; set; } = null!;

    public double Fiyat { get; set; }

    public double Miktar { get; set; }

    public double Tutar { get; set; }

    public string Dovizkod { get; set; } = null!;

    public double Kur { get; set; }

    public string Planurunkod { get; set; } = null!;

    public double Planlananfiyat { get; set; }

    public double Planlananmiktar { get; set; }

    public double Planlanantutar { get; set; }

    public string Planlanandovizkod { get; set; } = null!;

    public double Planlanankur { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
