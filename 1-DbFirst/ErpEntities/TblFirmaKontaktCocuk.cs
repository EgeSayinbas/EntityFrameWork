using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblFirmaKontaktCocuk
{
    public string Firmakod { get; set; } = null!;

    public string Kisikod { get; set; } = null!;

    public string? Cocukadi { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Bilgi { get; set; }

    public int? Hatirno { get; set; }
}
