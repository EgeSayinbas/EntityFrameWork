using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblMakinaCalisma
{
    public string Makinakodu { get; set; } = null!;

    public DateTime Tarih { get; set; }

    public bool? Calisiyor { get; set; }

    public DateTime? Baslamasaat { get; set; }

    public DateTime? Bitissaat { get; set; }
}
