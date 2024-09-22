using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblIslem
{
    public string Islemkod { get; set; } = null!;

    public string Kodaciklama { get; set; } = null!;

    public string Islemtipkod { get; set; } = null!;

    public string Baskitipkod { get; set; } = null!;

    public string Bicaktipkod { get; set; } = null!;

    public double Fiyat { get; set; }

    public string Dovizkod { get; set; } = null!;

    public string Fiyatbirim { get; set; } = null!;

    public bool Yaldiz { get; set; }

    public bool Yaldizbaski { get; set; }

    public string Bilgi { get; set; } = null!;

    public double Minalan { get; set; }

    public double Maksalan { get; set; }

    public string Teklifteyaz { get; set; } = null!;

    public string Islemaktif { get; set; } = null!;

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string? Ek3 { get; set; }

    public string? Ek4 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
