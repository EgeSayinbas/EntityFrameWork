using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblMaliyetIndirim
{
    public int Indirimno { get; set; }

    public int Maliyetkodu { get; set; }

    public short Yuzdeindirim { get; set; }

    public string Sebep { get; set; } = null!;

    public bool? Iptal { get; set; }

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
