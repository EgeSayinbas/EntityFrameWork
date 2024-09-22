using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblGrafikOnay
{
    public long Grafno { get; set; }

    public long Grafikno { get; set; }

    public DateTime? Gidistarih { get; set; }

    public DateTime? Gelistarih { get; set; }

    public string Grafikislemkod { get; set; } = null!;

    public string Aciklama { get; set; } = null!;
}
