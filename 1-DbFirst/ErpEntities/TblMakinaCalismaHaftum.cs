using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblMakinaCalismaHaftum
{
    public string Makinakodu { get; set; } = null!;

    public string Gun { get; set; } = null!;

    public bool? Calisiyor { get; set; }

    public DateTime? Baslamasaat { get; set; }

    public DateTime? Bitissaat { get; set; }
}
