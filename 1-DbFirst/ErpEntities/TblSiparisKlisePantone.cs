using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblSiparisKlisePantone
{
    public long Siparispantoneid { get; set; }

    public long Siparisno { get; set; }

    public long Klisepantoneid { get; set; }

    public string Klisekod { get; set; } = null!;

    public string Urunkod { get; set; } = null!;

    public int Sonno { get; set; }

    public string Pantoneno { get; set; } = null!;

    public string Kliseuyumkod { get; set; } = null!;

    public string Formul { get; set; } = null!;

    public string Aniloxkod { get; set; } = null!;

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
