using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblUrunStokkart
{
    public long Stokid { get; set; }

    public string Stokkod { get; set; } = null!;

    public string Uruntipkod { get; set; } = null!;

    public string Urunkod { get; set; } = null!;

    public short Urunno { get; set; }

    public string Firmakod { get; set; } = null!;

    public double Miktar1 { get; set; }

    public double Miktar2 { get; set; }

    public int Tabaka { get; set; }

    public double Netmiktar { get; set; }

    public string Birimkod { get; set; } = null!;

    public double Stokgramaji { get; set; }

    public DateTime Tarih { get; set; }

    public string Kagittipi { get; set; } = null!;

    public string Setmi { get; set; } = null!;

    public double Tabakaboy { get; set; }

    public string Depokod { get; set; } = null!;

    public string Aciklama { get; set; } = null!;

    public string Uyarinotu { get; set; } = null!;

    public int Sevkiyatno { get; set; }

    public int Sevkiyatno2 { get; set; }

    public int Koliadet { get; set; }

    public int Ruloadet { get; set; }

    public string Urunadet { get; set; } = null!;

    public double Toplamadet { get; set; }

    public string Rafkodu { get; set; } = null!;

    public double Fiyat { get; set; }

    public string Dovizkod { get; set; } = null!;

    public double Fiyattl { get; set; }

    public int Siparisno { get; set; }

    public string Gideceksiparisno { get; set; } = null!;

    public string Giriskkno { get; set; } = null!;

    public int Teslimno { get; set; }

    public string Kkpersonelkodu { get; set; } = null!;

    public string Dosyano { get; set; } = null!;

    public double Sevkbekleyenmiktar { get; set; }

    public string Faturaedildi { get; set; } = null!;

    public long Faturasevkno { get; set; }

    public string Sarfedildi { get; set; } = null!;

    public long Sikayetno { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
