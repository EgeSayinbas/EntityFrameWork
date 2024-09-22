using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblGrafik
{
    public long Grafikno { get; set; }

    public string Grafikadi { get; set; } = null!;

    public string Firmakod { get; set; } = null!;

    public string Kliseno { get; set; } = null!;

    public byte Hat { get; set; }

    public string Isinsekli { get; set; } = null!;

    public DateTime? Baslatarih { get; set; }

    public DateTime? Bitistarih { get; set; }

    public string Aciklama { get; set; } = null!;

    public string Gecikme { get; set; } = null!;

    public string Grafikdurumkod { get; set; } = null!;

    public short Netsure { get; set; }

    public int Siparisno { get; set; }

    public string Urunkod { get; set; } = null!;

    public long Maliyetkodu { get; set; }

    public string Personelkodu { get; set; } = null!;

    public string Montaj { get; set; } = null!;

    public string Takip { get; set; } = null!;

    public short Sirala { get; set; }

    public short Siralagrafiker { get; set; }

    public string Akisyonu { get; set; } = null!;

    public string Uygulamasekli { get; set; } = null!;

    public string Gelenorjinal { get; set; } = null!;

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
