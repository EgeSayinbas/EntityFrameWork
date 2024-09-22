using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblUrunRevizyon
{
    public string Urunkod { get; set; } = null!;

    public string Revizyonkod { get; set; } = null!;

    public string Alan { get; set; } = null!;

    public string? Eskiveri { get; set; }

    public string? Yeniveri { get; set; }

    public string Desigtirenadisoyadi { get; set; } = null!;

    public DateTime Degistirmetarihi { get; set; }
}
