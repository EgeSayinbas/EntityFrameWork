using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblSiparisDegisiklik
{
    public int Siparisno { get; set; }

    public string Degisiklik { get; set; } = null!;
}
