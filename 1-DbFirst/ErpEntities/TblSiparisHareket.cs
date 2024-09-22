using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblSiparisHareket
{
    public int Siparisno { get; set; }

    public string Urunkod { get; set; } = null!;

    public long Urunihtiyacid { get; set; }

    public int Hareketno { get; set; }

    public double Harcananhareket { get; set; }

    public double Bitishareket { get; set; }

    public double Toplammiktar2 { get; set; }

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
