using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class VwSiparisArsiv
{
    public string? Kisaad { get; set; }

    public string Urunkod { get; set; } = null!;

    public string? Urunadi { get; set; }

    public double Siparismiktar { get; set; }

    public string? Firmakod { get; set; }

    public string? Personelkodu { get; set; }

    public string? Personelkodu2 { get; set; }

    public DateTime Siparistarih { get; set; }

    public double Toplamteslim { get; set; }

    public int Siparisno { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }

    public bool Iptal { get; set; }

    public double Siparisfiyat { get; set; }

    public string Dovizkod { get; set; } = null!;

    public string? Dovizaciklama { get; set; }
}
