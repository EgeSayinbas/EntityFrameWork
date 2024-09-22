using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblMakinaGider
{
    public string Makinakodu { get; set; } = null!;

    public double? Genelgiderpayi { get; set; }

    public double? Iscilikgideri { get; set; }

    public double? Elektrikgideri { get; set; }

    public string Gidergrupkod { get; set; } = null!;

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
