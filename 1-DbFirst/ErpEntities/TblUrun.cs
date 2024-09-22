using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblUrun
{
    public string Urunkod { get; set; } = null!;

    public string Revizyonkod { get; set; } = null!;

    public string Uruntipkod { get; set; } = null!;

    public string Musterikod { get; set; } = null!;

    public string Mamultip { get; set; } = null!;

    public int Mamultipkod { get; set; }

    public string Slevetip { get; set; } = null!;

    public string Urunadi { get; set; } = null!;

    public string Urunfaturaadi { get; set; } = null!;

    public string UrunadiIngilizce { get; set; } = null!;

    public string Spekkod { get; set; } = null!;

    public string Birimkod { get; set; } = null!;

    public double Tekebadboy { get; set; }

    public double Tekebaden { get; set; }

    public double Tekebadyukseklik { get; set; }

    public short Yyadet { get; set; }

    public double Aabosluk { get; set; }

    public double Yybosluk { get; set; }

    public short Yybitisikadet { get; set; }

    public double Baskiaabosluk { get; set; }

    public double Lf { get; set; }

    public double Yapistirmapayi { get; set; }

    public double Cl { get; set; }

    public string Malzemekod { get; set; } = null!;

    public bool Malzemezorunlu { get; set; }

    public string Malzemekod2 { get; set; } = null!;

    public short Malzemeek { get; set; }

    public short Bicakek { get; set; }

    public short Makinaek { get; set; }

    public string Kliseno { get; set; } = null!;

    public string Yapiskankod { get; set; } = null!;

    public string Tasiyicikod { get; set; } = null!;

    public string Laminasyoncinsi { get; set; } = null!;

    public string Bicakkodu { get; set; } = null!;

    public double Minstok { get; set; }

    public double Maxstok { get; set; }

    public double Siparismiktar { get; set; }

    public string Muhasebekod { get; set; } = null!;

    public string Urunnot { get; set; } = null!;

    public string Imalatcikod { get; set; } = null!;

    public bool Adettakim { get; set; }

    public short Takimmiktar { get; set; }

    public string Rulobirim { get; set; } = null!;

    public bool Adettakim2 { get; set; }

    public short Takimmiktar2 { get; set; }

    public string Yarimamulkod { get; set; } = null!;

    public string Kullanimalanikod { get; set; } = null!;

    public string Yapisalkod1 { get; set; } = null!;

    public string Yapisalkod2 { get; set; } = null!;

    public string Yapisalkod3 { get; set; } = null!;

    public string Opaklikkod { get; set; } = null!;

    public string Parlaklikkod { get; set; } = null!;

    public string Cekeryuzde { get; set; } = null!;

    public double Yogunluk { get; set; }

    public short Kalinlik { get; set; }

    public double Gramaj { get; set; }

    public double Gramajbutun { get; set; }

    public string Paketmiktar { get; set; } = null!;

    public string Paketbirimkod { get; set; } = null!;

    public string Iccap { get; set; } = null!;

    public double Fiyat { get; set; }

    public double Maliyetfiyat { get; set; }

    public double Acilisfiyat { get; set; }

    public string Uretimonay { get; set; } = null!;

    public DateTime? Uretimonaytarih { get; set; }

    public string Uretimpersonel { get; set; } = null!;

    public string Grafikonay { get; set; } = null!;

    public DateTime? Grafikonaytarih { get; set; }

    public string Grafikpersonel { get; set; } = null!;

    public double Alan { get; set; }

    public double Agirlik { get; set; }

    public bool Ambalaj { get; set; }

    public double Depolama { get; set; }

    public string Sabagkod { get; set; } = null!;

    public int Maliyetkodu { get; set; }

    public double Adetagirlik { get; set; }

    public double Adeten { get; set; }

    public double Adetboy { get; set; }

    public string Genelkod { get; set; } = null!;

    public string Firmakod { get; set; } = null!;

    public string Maliyetbirimkod { get; set; } = null!;

    public string Imalatkod { get; set; } = null!;

    public string Imalatadi { get; set; } = null!;

    public string Baskitipkod { get; set; } = null!;

    public string Eskiurunkod { get; set; } = null!;

    public bool Urunkullanilmiyor { get; set; }

    public double Uruneken { get; set; }

    public double Tasiyicieken { get; set; }

    public string Gidergrupkod { get; set; } = null!;

    public double Konsinyemiktar { get; set; }

    public double Konsinyealan { get; set; }

    public DateTime? Konsinyetarih { get; set; }

    public string Hammaddefiyatbirimi { get; set; } = null!;

    public string Resim { get; set; } = null!;

    public DateTime? Resimtarihi { get; set; }

    public string Uygulamasekli { get; set; } = null!;

    public string Holtmelt { get; set; } = null!;

    public string Perfore { get; set; } = null!;

    public bool Devamlilik { get; set; }

    public string Arsivno { get; set; } = null!;

    public string Boyayogunluk { get; set; } = null!;

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
