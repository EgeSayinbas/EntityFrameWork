using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblVardiyaUrunFire
{
    public int Vardiyano { get; set; }

    public int Vardiyaaltno { get; set; }

    public string Urunfirekod { get; set; } = null!;

    public string Urunkod { get; set; } = null!;

    public string Siparisurunkod { get; set; } = null!;

    public string Aciklama { get; set; } = null!;

    public double Miktar { get; set; }

    public double Netmiktar { get; set; }

    public string Birimkod { get; set; } = null!;

    public int Siparisno { get; set; }

    public string Islemkod { get; set; } = null!;

    public string Personelkodu { get; set; } = null!;

    public string Makinakodu { get; set; } = null!;

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
