using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class VwSipari
{
    public int Siparisno { get; set; }

    public string Urunkod { get; set; } = null!;

    public double Siparismiktar { get; set; }

    public string Birimkod { get; set; } = null!;

    public DateTime Siparistarih { get; set; }

    public string Siparisbirim { get; set; } = null!;

    public double Siparisfiyat { get; set; }

    public string Dovizkod { get; set; } = null!;

    public string Firmakod { get; set; } = null!;

    public bool KontrolKapat { get; set; }

    public string? Urunadi { get; set; }

    public string? Musterikod { get; set; }

    public string? Ticariad { get; set; }

    public string? Kisaad { get; set; }
}
