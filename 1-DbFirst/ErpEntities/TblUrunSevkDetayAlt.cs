using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblUrunSevkDetayAlt
{
    public long Urunsevkaltid { get; set; }

    public long Urunsevkdetayid { get; set; }

    public long Urunsevkid { get; set; }

    public string Stokkod { get; set; } = null!;

    public long Siparisno { get; set; }

    public string Takimtek { get; set; } = null!;

    public string Setmi { get; set; } = null!;

    public string Firmakod { get; set; } = null!;

    public string Subekod { get; set; } = null!;

    public string Urunkod { get; set; } = null!;

    public short Urunno { get; set; }

    public double Sevkmiktar { get; set; }

    public double Agirlik { get; set; }

    public string Belgekesildi { get; set; } = null!;

    public string Belgetipi { get; set; } = null!;

    public double Yenifiyat { get; set; }

    public string Birimkod { get; set; } = null!;

    public bool Onaysiz { get; set; }
}
