using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblMakinaDisli
{
    public string Makinakodu { get; set; } = null!;

    public string Islemkod { get; set; } = null!;

    public string Dislisayisi { get; set; } = null!;

    public string Dislisayisi2 { get; set; } = null!;

    public string Dislisayisi3 { get; set; } = null!;

    public float Dislidegeri { get; set; }

    public short Islemunitesayisi { get; set; }

    public double Manyetiken { get; set; }

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
