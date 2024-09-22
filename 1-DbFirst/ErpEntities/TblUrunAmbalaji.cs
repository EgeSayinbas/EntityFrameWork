using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblUrunAmbalaji
{
    public string Urunkod { get; set; } = null!;

    public float? En { get; set; }

    public float? Boy { get; set; }

    public float? Yuk { get; set; }

    public float? Hacim { get; set; }

    public float? Agirlik { get; set; }

    public float? Miktar { get; set; }
}
