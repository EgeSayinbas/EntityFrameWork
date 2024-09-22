using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblUrunSevk
{
    public long Urunsevkid { get; set; }

    public string Stokkod { get; set; } = null!;

    public long Siparisno { get; set; }

    public string Urunkod { get; set; } = null!;

    public short Urunno { get; set; }

    public string Setmi { get; set; } = null!;

    public string Takimtek { get; set; } = null!;

    public string Firmakod { get; set; } = null!;

    public string Subekod { get; set; } = null!;

    public double Miktar { get; set; }

    public string Sevkedildi { get; set; } = null!;

    public DateTime? Sevktaleptarihi { get; set; }

    public int Koliadet { get; set; }

    public int Ruloadet { get; set; }

    public string Urunadet { get; set; } = null!;

    public double Fiyat { get; set; }

    public string Dovizkod { get; set; } = null!;

    public string Birimkod { get; set; } = null!;

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
