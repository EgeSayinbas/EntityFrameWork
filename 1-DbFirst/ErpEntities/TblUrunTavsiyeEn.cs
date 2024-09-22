using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblUrunTavsiyeEn
{
    public string Urunkod { get; set; } = null!;

    public byte Yyadet { get; set; }

    public float En { get; set; }
}
