using System;
using System.Collections.Generic;

namespace _1_DbFirst.Erp;

public partial class TblArac
{
    public int Aracid { get; set; }

    public string Kodaciklama { get; set; } = null!;

    public double Tonaj { get; set; }

    public string Kullanma { get; set; } = null!;

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
