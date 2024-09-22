using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblSaSiparisSipari
{
    public long Sasaid { get; set; }

    public int Said { get; set; }

    public int Sasiparisno { get; set; }

    public string Sira { get; set; } = null!;

    public int Siparisno { get; set; }

    public long Sipihtiyacid { get; set; }
}
