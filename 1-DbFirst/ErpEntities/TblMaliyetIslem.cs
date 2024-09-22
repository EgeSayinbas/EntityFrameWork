using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblMaliyetIslem
{
    public long Maliyetislemid { get; set; }

    public int Maliyetkodu { get; set; }

    public short Ekgecis { get; set; }

    public byte Sira { get; set; }

    public string Takipadi { get; set; } = null!;

    public string Islemkod { get; set; } = null!;

    public string Islemtipkod { get; set; } = null!;

    public string Makinakodu { get; set; } = null!;

    public short Islemtekrari { get; set; }

    public double Fiyat { get; set; }

    public string Dovizkod { get; set; } = null!;

    public string Birimkod { get; set; } = null!;

    public string Ekstragideradi { get; set; } = null!;

    public string Ektragiderbirim { get; set; } = null!;

    public double Ekstragiderfiyat { get; set; }

    public string Ektradovizkod { get; set; } = null!;

    public string Dislisayisi { get; set; } = null!;

    public short Aaadet { get; set; }

    public short Yyadet { get; set; }

    public float Dislidegeri { get; set; }

    public double Yuzdefire { get; set; }

    public double Setupfire { get; set; }

    public string Aciklama { get; set; } = null!;

    public double Setupfiyat { get; set; }

    public string Setupdovizkod { get; set; } = null!;

    public double Artisaattehiz { get; set; }

    public double Boyabirimfiyat { get; set; }

    public string Boyadovizkod { get; set; } = null!;

    public double Boyayogunlugu { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
