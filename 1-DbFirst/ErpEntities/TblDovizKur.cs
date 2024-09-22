using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblDovizKur
{
    public DateTime Tarih { get; set; }

    public string Dovizkod { get; set; } = null!;

    public double? Dovizalisf { get; set; }

    public double? Dovizsatisf { get; set; }

    public double? Efektifalisf1 { get; set; }

    public double? Efektifsatisf1 { get; set; }

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
