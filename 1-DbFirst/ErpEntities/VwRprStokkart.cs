using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class VwRprStokkart
{
    public string Stokkod { get; set; } = null!;

    public string Uruntipkod { get; set; } = null!;

    public string Urunkod { get; set; } = null!;

    public string Firmakod { get; set; } = null!;

    public double Miktar1 { get; set; }

    public double Miktar2 { get; set; }

    public double Netmiktar { get; set; }

    public string Birimkod { get; set; } = null!;

    public DateTime Tarih { get; set; }

    public string Depokod { get; set; } = null!;

    public int Sevkiyatno { get; set; }

    public double Toplamadet { get; set; }

    public double Fiyat { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }

    public string? Kisaad { get; set; }

    public string? Kodaciklama { get; set; }

    public string? Urunadi { get; set; }

    public string? Stokno { get; set; }

    public string? Tasiyiciad { get; set; }

    public string? Yapiskanad { get; set; }

    public string? Yapisalkod1 { get; set; }

    public string? Yapisalkod2 { get; set; }

    public string? Yapisalkod3 { get; set; }

    public string? Parlaklikkod { get; set; }

    public string? Kullanimalanikod { get; set; }

    public string? Yarimamulkod { get; set; }

    public string? Opaklikkod { get; set; }

    public string? Yapiskankod { get; set; }

    public string? Tasiyicikod { get; set; }

    public string? Imalatcikod { get; set; }

    public string? Paketbirimkod { get; set; }

    public string? Cekeryuzde { get; set; }

    public short? Kalinlik { get; set; }

    public short? Gramaj { get; set; }

    public string? Paketmiktar { get; set; }

    public double? Tekebaden { get; set; }

    public double? Tekebadboy { get; set; }

    public string? Iccap { get; set; }

    public string? Ticariad { get; set; }

    public string? Imalatkod { get; set; }

    public string Aciklama { get; set; } = null!;

    public int Siparisno { get; set; }

    public string Gideceksiparisno { get; set; } = null!;

    public string? Birimadi { get; set; }

    public long Stokid { get; set; }

    public string Giriskkno { get; set; } = null!;

    public int Teslimno { get; set; }

    public int Tabaka { get; set; }

    public double Stokgramaji { get; set; }

    public string Kagittipi { get; set; } = null!;

    public string Setmi { get; set; } = null!;

    public double Tabakaboy { get; set; }

    public string Uyarinotu { get; set; } = null!;

    public int Koliadet { get; set; }

    public int Ruloadet { get; set; }

    public string Urunadet { get; set; } = null!;

    public string Rafkodu { get; set; } = null!;

    public string Dovizkod { get; set; } = null!;

    public double Fiyattl { get; set; }

    public string Kkpersonelkodu { get; set; } = null!;

    public string Dosyano { get; set; } = null!;

    public double Sevkbekleyenmiktar { get; set; }

    public string Faturaedildi { get; set; } = null!;

    public long Faturasevkno { get; set; }

    public string? Imalatadi { get; set; }

    public string? Birimtip { get; set; }
}
