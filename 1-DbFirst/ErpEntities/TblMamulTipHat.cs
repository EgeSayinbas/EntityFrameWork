using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblMamulTipHat
{
    public int Mamultipkod { get; set; }

    public byte Hat { get; set; }

    public string Hatadi { get; set; } = null!;

    public byte Minimumurun { get; set; }
}
