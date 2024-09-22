using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblUrunSevkDetay
{
    public long Urunsevkdetayid { get; set; }

    public int Aracid { get; set; }

    public string Plaka { get; set; } = null!;

    public DateTime? Sevktarih { get; set; }

    public double Toplamagirlik { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
