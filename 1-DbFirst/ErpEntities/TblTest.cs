using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblTest
{
    public string Testtipi { get; set; } = null!;

    public int Minadet { get; set; }

    public int Maxadet { get; set; }

    public int Minmetre { get; set; }

    public int Maxmetre { get; set; }

    public short Numuneadet { get; set; }
}
