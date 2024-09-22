using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblSiparisTeslim2
{
    public int Sevkiyatno { get; set; }

    public int Siparisno { get; set; }

    public short Urunno { get; set; }

    public DateTime? Teslimtarih { get; set; }

    public int Koliadet { get; set; }

    public int Ruloadet { get; set; }

    public string Urunadet { get; set; } = null!;

    public double Toplamadet { get; set; }

    public bool Musteri { get; set; }

    public bool Depo { get; set; }

    public bool Konsinye { get; set; }

    public bool Depodansevk { get; set; }

    public string Depokod { get; set; } = null!;

    public string Firmakod { get; set; } = null!;

    public bool Sevkedildi { get; set; }

    public string Aciklama { get; set; } = null!;

    public double Koliagirlik { get; set; }

    public double Sevkmiktar { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
