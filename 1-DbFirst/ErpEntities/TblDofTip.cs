using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblDofTip
{
    public string Dofkod { get; set; } = null!;

    public string? Tipkod { get; set; }

    public string? Aciklama { get; set; }

    public string? Nedeneylem { get; set; }
}
