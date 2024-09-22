using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class VwSaSiparisOnay
{
    public int Said { get; set; }

    public int Sasiparisno { get; set; }

    public string Sira { get; set; } = null!;

    public string Urunkod { get; set; } = null!;

    public string? Urunadi { get; set; }

    public string? Dovizaciklama { get; set; }

    public string Firmakod { get; set; } = null!;

    public string? Kisaad { get; set; }

    public string Birimkod { get; set; } = null!;

    public string? Simge { get; set; }

    public string Yonetimonay { get; set; } = null!;

    public double Netmiktar { get; set; }

    public double Fiyat { get; set; }

    public double Tutar { get; set; }

    public double Fiyattl { get; set; }

    public double Tutartl { get; set; }

    public string Yonetimonay2 { get; set; } = null!;

    public string Bicakkodu { get; set; } = null!;

    public bool Bicak { get; set; }

    public string Satipi { get; set; } = null!;
}
