using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblTeklifSira
{
    public long Teklifsiraid { get; set; }

    public long Kodu { get; set; }

    public string Sirano { get; set; } = null!;

    public long Maliyetkodu { get; set; }

    public double Klisemasraf { get; set; }

    public string Kdovizkod { get; set; } = null!;

    public double Bicakmasraf { get; set; }

    public string Bdovizkod { get; set; } = null!;

    public string Uruntipkod { get; set; } = null!;

    public bool Teklifonay { get; set; }

    public string Urunnot { get; set; } = null!;

    public string Urunnot2 { get; set; } = null!;

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string? Ek3 { get; set; }

    public string? Ek4 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
