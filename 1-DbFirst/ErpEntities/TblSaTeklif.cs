using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblSaTeklif
{
    public int Sateklifkod { get; set; }

    public string Firmakod { get; set; } = null!;

    public string Sabagkod { get; set; } = null!;

    public string? Uruntipkod { get; set; }

    public string Urunkod { get; set; } = null!;

    public string Bicakkodu { get; set; } = null!;

    public bool? Bicak { get; set; }

    public bool? Klise { get; set; }

    public DateTime? Baslatarih { get; set; }

    public DateTime? Bitistarih { get; set; }

    public short? Vade { get; set; }

    public string? Eksart { get; set; }

    public string? Teslimatkod { get; set; }

    public string? Teslimatyeri { get; set; }

    public string? Sevkiyatkod { get; set; }

    public string? Ambalaj { get; set; }

    public string? Odemekod { get; set; }

    public byte? Garanti { get; set; }

    public string? Imalatcikod { get; set; }

    public string? Personelkodu { get; set; }

    public bool Iptal { get; set; }

    public string Tedarikcikodu { get; set; } = null!;

    public string Tedarikciadi { get; set; } = null!;

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string? Ek3 { get; set; }

    public string? Ek4 { get; set; }

    public string? Olusturanadisoyadi { get; set; }

    public DateTime? Olusturmatarihi { get; set; }
}
