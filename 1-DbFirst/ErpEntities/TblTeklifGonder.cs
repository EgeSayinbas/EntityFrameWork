using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblTeklifGonder
{
    public long Kodu { get; set; }

    public int Gonderno { get; set; }

    public string Gonderkodu { get; set; } = null!;

    public DateTime Gondertarih { get; set; }

    public string Sonucteklifkod { get; set; } = null!;

    public string Personelkodu { get; set; } = null!;

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
