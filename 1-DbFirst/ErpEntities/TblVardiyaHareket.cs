using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblVardiyaHareket
{
    public int Vardiyano { get; set; }

    public int Vardiyaaltno { get; set; }

    public string Urunkod { get; set; } = null!;

    public bool Hammadde { get; set; }

    public int Hareketno { get; set; }

    public double Harcananalan { get; set; }

    public double Firealan { get; set; }

    public double Harcananalan2 { get; set; }
}
