using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblSiparisKlise
{
    public int Siparisno { get; set; }

    public string Klisekod { get; set; } = null!;

    public string Urunkod { get; set; } = null!;

    public string Pantoneno { get; set; } = null!;

    public string Kliseuyumkod { get; set; } = null!;

    public string Formul { get; set; } = null!;

    public string Aniloxkod { get; set; } = null!;
}
