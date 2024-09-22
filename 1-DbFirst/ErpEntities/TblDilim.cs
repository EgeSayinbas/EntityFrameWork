using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblDilim
{
    public string Urunkod { get; set; } = null!;

    public string Stokkod { get; set; } = null!;

    public string Stokno { get; set; } = null!;

    public string Dilmeno { get; set; } = null!;

    public double Eskimiktar1 { get; set; }

    public double? Eskimiktar2 { get; set; }

    public double Miktar1 { get; set; }

    public double? Miktar2 { get; set; }

    public string Birimkod { get; set; } = null!;

    public byte Seviye { get; set; }

    public int Dilmekod { get; set; }

    public string? Gideceksiparisno { get; set; }

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
