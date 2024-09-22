using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblBicakDisli
{
    public string Bicakkodu { get; set; } = null!;

    public string? Dislisayisi { get; set; }

    public string? Dislisayisi2 { get; set; }

    public float? Dislidegeri { get; set; }
}
