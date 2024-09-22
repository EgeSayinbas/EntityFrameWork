using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblMakinaIslem
{
    public int Makinaislemkod { get; set; }

    public string Makinakodu { get; set; } = null!;

    public string Islemkod { get; set; } = null!;

    public string Iptal { get; set; } = null!;

    public bool Elisciligi { get; set; }

    public bool Fason { get; set; }

    public string Islemtipkod { get; set; } = null!;

    public short Ortsetupdakika { get; set; }

    public double Ortsaatehiz { get; set; }

    public string Makinabirimkod { get; set; } = null!;

    public double Setupfire { get; set; }

    public double Yuzdefire { get; set; }

    public double Maksen { get; set; }

    public double Maksboy { get; set; }

    public double Minen { get; set; }

    public double Minboy { get; set; }

    public short Islemunitesayisi { get; set; }

    public bool Dislivar { get; set; }

    public bool Dislisizvar { get; set; }

    public bool Yandondur { get; set; }

    public bool Semirot { get; set; }

    public double Dislidegeri { get; set; }

    public double Fiyat { get; set; }

    public string Dovizkod { get; set; } = null!;

    public string Fiyatbirim { get; set; } = null!;

    public string Birimkod { get; set; } = null!;

    public string Bicaktipkod { get; set; } = null!;

    public string Baskitipkod { get; set; } = null!;

    public int Kesim { get; set; }

    public bool Bol { get; set; }

    public bool Baski { get; set; }

    public double Setupfiyat { get; set; }

    public string Setupdovizkod { get; set; } = null!;

    public double Urunyyadetorani { get; set; }

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string? Ek3 { get; set; }

    public string? Ek4 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
