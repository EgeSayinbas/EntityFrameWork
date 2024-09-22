using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblVardiyaBicak
{
    public int Vardiyaaltno { get; set; }

    public string Bicakkodu { get; set; } = null!;

    public string Yenilemeno { get; set; } = null!;

    public int Tursayisi { get; set; }
}
