using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblBicak
{
    public long BicakId { get; set; }

    public string Bicakkodu { get; set; } = null!;

    public string Bicakuzunkod { get; set; } = null!;

    public string Kisakod { get; set; } = null!;

    public string Bicakno { get; set; } = null!;

    public string Arsivno { get; set; } = null!;

    public bool Bicakyonu { get; set; }

    public string Dislisayisi { get; set; } = null!;

    public double Tekebadboy { get; set; }

    public double Tekebaden { get; set; }

    public short Aaadet { get; set; }

    public short Yyadet { get; set; }

    public float Radus { get; set; }

    public string Bicaktipkod { get; set; } = null!;

    public double Aabosluk { get; set; }

    public double Yybosluk { get; set; }

    public short Yybitisikadet { get; set; }

    public string Ozelbilgi { get; set; } = null!;

    public string Firmakod { get; set; } = null!;

    public string Urunkod { get; set; } = null!;

    public short Bicakek { get; set; }

    public string Grafikonay { get; set; } = null!;

    public string Kullanimalanikod { get; set; } = null!;

    public string Bicakiz { get; set; } = null!;

    public DateTime? Bicakiztarihi { get; set; }

    public string Sabagkod { get; set; } = null!;

    public int Bicaksekilkod { get; set; }

    public string Ds { get; set; } = null!;

    public string Yenibicak { get; set; } = null!;

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string? Ek3 { get; set; }

    public string? Ek4 { get; set; }

    public string? Olusturanadisoyadi { get; set; }

    public DateTime? Olusturmatarihi { get; set; }
}
