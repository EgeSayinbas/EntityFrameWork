using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblVardiyaUrun
{
    public int Vardiyano { get; set; }

    public int Vardiyaaltno { get; set; }

    public string Urunkod { get; set; } = null!;

    public double Depocikis { get; set; }

    public double Depoiade { get; set; }

    public bool Depoiadekontrol { get; set; }

    public double Deviralinan { get; set; }

    public double Devirverilen { get; set; }

    public double Sarfiyat { get; set; }

    public double Harcanan { get; set; }

    public double Netharcanan { get; set; }

    public double Toplamadet { get; set; }

    public string Birimkod { get; set; } = null!;

    public string Personelkodu { get; set; } = null!;

    public bool Hammadde { get; set; }

    public int Hareketno { get; set; }

    public short Sira { get; set; }

    public short Birlesikadet { get; set; }

    public bool Kullanildi { get; set; }

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
