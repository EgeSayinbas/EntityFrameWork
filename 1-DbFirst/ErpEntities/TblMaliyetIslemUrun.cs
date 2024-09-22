using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblMaliyetIslemUrun
{
    public long Maliyetislemurunid { get; set; }

    public int Maliyetkodu { get; set; }

    public long Maliyetislemid { get; set; }

    public string Islemkod { get; set; } = null!;

    public string Urunkod { get; set; } = null!;

    public string Uruntipkod { get; set; } = null!;

    public string Birimkod { get; set; } = null!;

    public string Birimtip { get; set; } = null!;

    public bool Eniesit { get; set; }

    public bool Boyuesit { get; set; }

    public double En { get; set; }

    public double Boy { get; set; }

    public double Artien { get; set; }

    public double Artiboy { get; set; }

    public double Artitopen { get; set; }

    public double Artitopboy { get; set; }

    public double Yogunlukgram { get; set; }

    public double Yogunlukadet { get; set; }

    public double Yogunlukalan { get; set; }

    public double Hammaddefiyat { get; set; }

    public string Parabirimi { get; set; } = null!;

    public double Fiyateurokg { get; set; }

    public double Fiyateuroalan { get; set; }

    public double Malzemeuretimeni { get; set; }

    public byte Urunyyadet { get; set; }

    public byte Urunaaadet { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
