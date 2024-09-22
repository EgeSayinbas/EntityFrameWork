using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblUrunMalzeme
{
    public long Urunmalzemeid { get; set; }

    public string Urunkod { get; set; } = null!;

    public int Sira { get; set; }

    public string Yapisalkod { get; set; } = null!;

    public string Malzemekod { get; set; } = null!;

    public string Urunbirimkod { get; set; } = null!;

    public long Urunislemid { get; set; }

    public bool Hammadde { get; set; }

    public double Gramaj { get; set; }

    public double Malzemeuretimeni { get; set; }

    public byte Yyadet { get; set; }

    public string Hamyarimamul { get; set; } = null!;
}
