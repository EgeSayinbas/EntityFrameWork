using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblMaliyetOnay
{
    public long Maliyetonayid { get; set; }

    public int Maliyetkodu { get; set; }

    public DateTime? Tarih { get; set; }

    public double Miktar { get; set; }

    public double Fiyat { get; set; }

    public string Dovizkod { get; set; } = null!;

    public string Onaylayan { get; set; } = null!;
}
