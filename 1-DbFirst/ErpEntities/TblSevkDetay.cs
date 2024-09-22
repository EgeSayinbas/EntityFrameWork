using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblSevkDetay
{
    public long Satirdetayid { get; set; }

    public long Satirno { get; set; }

    public int Siparisno { get; set; }

    public long Urunsevkid { get; set; }

    public string Musterisano { get; set; } = null!;

    public string Urunkod { get; set; } = null!;

    public short Urunno { get; set; }

    public int Sevkiyatno { get; set; }

    public string Stokkod { get; set; } = null!;

    public int Koliadet { get; set; }

    public int Ruloadet { get; set; }

    public string Urunadet { get; set; } = null!;

    public double Adet { get; set; }
}
