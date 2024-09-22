using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblDilimGecici
{
    public string Stokkod { get; set; } = null!;

    public int Sira { get; set; }

    public double Boy { get; set; }
}
