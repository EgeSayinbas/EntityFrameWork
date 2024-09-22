using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblSikayetGelen
{
    public int Sikayetno { get; set; }

    public string Sikayettipi { get; set; } = null!;

    public string Iadedurum { get; set; } = null!;

    public DateTime? Sikayettarih { get; set; }

    public string Firmakod { get; set; } = null!;

    public string Kisikod { get; set; } = null!;

    public string Personelkodu { get; set; } = null!;

    public string Urunkod { get; set; } = null!;

    public int Siparisno { get; set; }

    public DateTime? Teslimtarih { get; set; }

    public double Toplamadet { get; set; }

    public int Sevkiyatno { get; set; }

    public double Sevkadet { get; set; }

    public string Irsaliyeno { get; set; } = null!;

    public long Sevkno { get; set; }

    public string Aciklama { get; set; } = null!;

    public string Dofkod { get; set; } = null!;

    public DateTime? Iadetarihi { get; set; }

    public string Musterisikayetno { get; set; } = null!;

    public double Zarartutari { get; set; }

    public string Resim { get; set; } = null!;

    public bool Bedelsiz { get; set; }

    public string Acik { get; set; } = null!;

    public string Degerlendirme { get; set; } = null!;

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string? Ek3 { get; set; }

    public string? Ek4 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
