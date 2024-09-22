using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblVardiya
{
    public int Vardiyano { get; set; }

    public int Siparisno { get; set; }

    public string Makinakodu { get; set; } = null!;

    public double Zamanfiretoplami { get; set; }

    public double Urunfirealan { get; set; }

    public double Urunalan { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
