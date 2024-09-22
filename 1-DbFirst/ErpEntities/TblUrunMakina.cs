using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblUrunMakina
{
    public long Urunislemid { get; set; }

    public string Urunkod { get; set; } = null!;

    public string Islemkod { get; set; } = null!;

    public short Sira { get; set; }

    public string Makinakodu { get; set; } = null!;

    public short Ekgecis { get; set; }

    public short Artisetupsure { get; set; }

    public double Artisaattehiz { get; set; }

    public double Dislidegeri { get; set; }

    public string Dislisayisi { get; set; } = null!;

    public short Aaadet { get; set; }

    public short Yyadet { get; set; }

    public short Islemsayisi { get; set; }

    public string Aciklama { get; set; } = null!;
}
