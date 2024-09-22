using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblVardiyaZaman
{
    public int Vardiyano { get; set; }

    public int Vardiyaaltno { get; set; }

    public long Siparismakinaid { get; set; }

    public DateTime Baslangicgun { get; set; }

    public DateTime? Baslangicsaat { get; set; }

    public DateTime Bitisgun { get; set; }

    public DateTime? Bitissaat { get; set; }

    public string Sorumlupersonelkodu { get; set; } = null!;

    public string Personelkodu { get; set; } = null!;

    public short Netsure { get; set; }

    public string Makinakodu { get; set; } = null!;

    public short Sira { get; set; }

    public double Uretimmiktar { get; set; }

    public short Bicakyyadet { get; set; }

    public short Bicakaaadet { get; set; }

    public double Neturetim { get; set; }

    public double Uretimmetraj { get; set; }

    public double Zamanfiretoplami { get; set; }

    public double Urunfirealan { get; set; }

    public double Urunalan { get; set; }

    public short Yikananunite { get; set; }

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string? Ek3 { get; set; }

    public string? Ek4 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
