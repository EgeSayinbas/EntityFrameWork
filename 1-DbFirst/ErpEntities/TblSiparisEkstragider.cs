using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblSiparisEkstragider
{
    public int Siparisno { get; set; }

    public string Ekstragiderkod { get; set; } = null!;

    public double Tutar { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
