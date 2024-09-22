using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblMaliyetMalzeme
{
    public long Maliyetmalzemeid { get; set; }

    public long Maliyetkodu { get; set; }

    public int Sira { get; set; }

    public string Yapisalkod { get; set; } = null!;

    public string Urunkod { get; set; } = null!;

    public string Urunbirimkod { get; set; } = null!;

    public long Maliyetislemid { get; set; }

    public bool Hammadde { get; set; }

    public double Gramaj { get; set; }

    public double Hammaddefiyat { get; set; }

    public string Parabirimi { get; set; } = null!;

    public double Fiyateurokg { get; set; }

    public double Fiyateuroalan { get; set; }

    public double Malzemeuretimeni { get; set; }
}
