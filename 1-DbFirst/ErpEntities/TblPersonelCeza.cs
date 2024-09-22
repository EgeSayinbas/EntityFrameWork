using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblPersonelCeza
{
    public int Cezaid { get; set; }

    public string Personelkodu { get; set; } = null!;

    public string Adi { get; set; } = null!;

    public bool? Ceza { get; set; }

    public string? Sebep { get; set; }

    public DateTime? Tarih { get; set; }
}
