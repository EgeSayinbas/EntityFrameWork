using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblVardiyaZamanFire
{
    public int Vardiyaaltno { get; set; }

    public string Zamanfirekod { get; set; } = null!;

    public short Miktar { get; set; }

    public string Aciklama { get; set; } = null!;

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
