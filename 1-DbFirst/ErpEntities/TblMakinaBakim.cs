using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblMakinaBakim
{
    public int Bakimno { get; set; }

    public string Bakimkod { get; set; } = null!;

    public string Makinakodu { get; set; } = null!;

    public string Talepeden { get; set; } = null!;

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public DateTime? Baslatarih { get; set; }

    public DateTime? Baslasaat { get; set; }

    public DateTime? Bitistarih { get; set; }

    public DateTime? Bitissaat { get; set; }

    public string Aciliyet { get; set; } = null!;

    public string Durumu { get; set; } = null!;

    public string Uretimdurdu { get; set; } = null!;

    public string Arizatanimi { get; set; } = null!;

    public string Bakimtanimi { get; set; } = null!;

    public int Hareketno { get; set; }

    public string Sonuc { get; set; } = null!;

    public string Bakimiyapan { get; set; } = null!;

    public short Sure { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
