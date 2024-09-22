using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblSevkAlt
{
    public long Satirno { get; set; }

    public long Sevkno { get; set; }

    public byte Sirano { get; set; }

    public int Siparisno { get; set; }

    public string Musterisano { get; set; } = null!;

    public string Urunkod { get; set; } = null!;

    public short Urunno { get; set; }

    public string Birimkod { get; set; } = null!;

    public int Sevkiyatno { get; set; }

    public string Stokkod { get; set; } = null!;

    public long Urunsevkdetayid { get; set; }

    public int Koliadet { get; set; }

    public int Ruloadet { get; set; }

    public string Urunadet { get; set; } = null!;

    public double Toplamadet { get; set; }

    public double Siparisfiyat { get; set; }

    public string Siparisdovizkod { get; set; } = null!;

    public double Kur { get; set; }

    public double Sabitkur { get; set; }

    public string Dovizalissatis { get; set; } = null!;

    public double Faturafiyat { get; set; }

    public double Iskontoyuzde { get; set; }

    public double Iskontotutar { get; set; }

    public double Tutar { get; set; }

    public double Kdv { get; set; }

    public double Kdvtutar { get; set; }

    public double Kdvlitutar { get; set; }

    public string Aciklama { get; set; } = null!;

    public bool Onaysiz { get; set; }
}
