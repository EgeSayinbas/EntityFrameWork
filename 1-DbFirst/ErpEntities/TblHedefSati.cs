using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblHedefSati
{
    public DateTime? Tarih { get; set; }

    public string? Ay { get; set; }

    public string? Yil { get; set; }

    public float? Hedef { get; set; }

    public string? Personelkodu { get; set; }
}
