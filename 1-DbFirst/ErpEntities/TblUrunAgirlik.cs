using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblUrunAgirlik
{
    public string Urunkod { get; set; } = null!;

    public double Urunmiktar { get; set; }

    public string Birimkod { get; set; } = null!;

    public double Tekebadboy { get; set; }

    public double Tekebaden { get; set; }

    public double Tekebadyukseklik { get; set; }

    public double Urunagirlik { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
