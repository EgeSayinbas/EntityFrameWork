using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblTeknikOrtam
{
    public int Teknikno { get; set; }

    public string Ortam { get; set; } = null!;
}
