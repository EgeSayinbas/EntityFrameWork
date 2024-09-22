using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblSaSiparisTeslimDetay
{
    public long Detayno { get; set; }

    public long Said { get; set; }

    public int Sasiparisno { get; set; }

    public string Sira { get; set; } = null!;

    public int Teslimno { get; set; }

    public double Boy { get; set; }

    public string Partino { get; set; } = null!;
}
