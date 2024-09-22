using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblUrunBirim
{
    public int Birimno { get; set; }

    public string Urunkod { get; set; } = null!;

    public string Birimkod { get; set; } = null!;

    public string Ekbirimkod { get; set; } = null!;

    public double Miktar { get; set; }

    public double Ekmiktar { get; set; }

    public double Birimoran { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
