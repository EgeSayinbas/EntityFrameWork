using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblBicakTip
{
    public string Bicaktipkod { get; set; } = null!;

    public string? Kodaciklama { get; set; }

    public string Simge { get; set; } = null!;

    public bool Dislivar { get; set; }

    public bool Dislisizvar { get; set; }

    public bool Yandondur { get; set; }

    public double Dislidegeri { get; set; }

    public double Maksboy { get; set; }

    public double Minboy { get; set; }

    public double Maksen { get; set; }

    public double Minen { get; set; }

    public double Fiyat { get; set; }

    public string Dovizkod { get; set; } = null!;

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string? Ek3 { get; set; }

    public string? Ek4 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
