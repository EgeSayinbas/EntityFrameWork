using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblMaliyet
{
    public long Maliyetkodu { get; set; }

    public string Firmakod { get; set; } = null!;

    public double Maliyeten { get; set; }

    public double Maliyetboy { get; set; }

    public double Maliyetadet { get; set; }

    public byte Maliyetrenk { get; set; }

    public int Mamultipkod { get; set; }

    public string Slevetip { get; set; } = null!;

    public bool BicakVar { get; set; }

    public bool Yenibicak { get; set; }

    public bool BaskiVar { get; set; }

    public byte Renk { get; set; }

    public string Makinakodu { get; set; } = null!;

    public string Makinakodub { get; set; } = null!;

    public short Bicakek { get; set; }

    public short Malzemeek { get; set; }

    public short Makinaek { get; set; }

    public string Bicakkodu { get; set; } = null!;

    public double Tekebadboy { get; set; }

    public double Tekebaden { get; set; }

    public double Tekebadyukseklik { get; set; }

    public short Yyadet { get; set; }

    public double Aabosluk { get; set; }

    public double Yybosluk { get; set; }

    public short Yybitisikadet { get; set; }

    public short Musteriyyadet { get; set; }

    public double Lf { get; set; }

    public double Cl { get; set; }

    public double Netenverimi { get; set; }

    public double Enverimi { get; set; }

    public bool BicakmasrafEkle { get; set; }

    public double Bicakmasraf { get; set; }

    public bool KlisemasrafEkle { get; set; }

    public double Klisetutar { get; set; }

    public string Malzemecinsi { get; set; } = null!;

    public bool MalzemecinsiEkle { get; set; }

    public double Malzemefiyat { get; set; }

    public double Gramaj { get; set; }

    public double Kalinlik { get; set; }

    public double Yogunluk { get; set; }

    public string Malzemecinsi2 { get; set; } = null!;

    public bool MalzemecinsiEkle2 { get; set; }

    public double Malzemefiyat2 { get; set; }

    public double Gramaj2 { get; set; }

    public bool VadeEkle { get; set; }

    public short Vade { get; set; }

    public float Vadevalor { get; set; }

    public bool BoyayogunluguEkle { get; set; }

    public string Boyayogunluk { get; set; } = null!;

    public double Boyafiyat { get; set; }

    public bool LaminasyoncinsiEkle { get; set; }

    public string Laminasyonadi { get; set; } = null!;

    public double Genelgidereur { get; set; }

    public double Genelgider { get; set; }

    public double Yonetimgideri { get; set; }

    public string Urunadi { get; set; } = null!;

    public string Urunkod { get; set; } = null!;

    public string Ozelbilgi { get; set; } = null!;

    public string Onayagonderen { get; set; } = null!;

    public DateTime? Onayagondertarih { get; set; }

    public string KontrolMaliyet { get; set; } = null!;

    public bool DurumKontrol { get; set; }

    public string Teklifbirimi { get; set; } = null!;

    public string Birimkod { get; set; } = null!;

    public bool Baskibicakayri { get; set; }

    public string Bicaktipkod { get; set; } = null!;

    public bool Adettakim { get; set; }

    public short Takimmiktar { get; set; }

    public string Rulobirim { get; set; } = null!;

    public bool Adettakim2 { get; set; }

    public short Takimmiktar2 { get; set; }

    public short Takimuretimmiktar { get; set; }

    public double Depolama { get; set; }

    public string Uruntipkod { get; set; } = null!;

    public string Dovizkod { get; set; } = null!;

    public bool Ribon { get; set; }

    public string Musterikod { get; set; } = null!;

    public string Onayliyan { get; set; } = null!;

    public DateTime? Onaytarih { get; set; }

    public double Uruneken { get; set; }

    public double Maliyeteken { get; set; }

    public float Baglamaucreti { get; set; }

    public string Baglamaparabirimi { get; set; } = null!;

    public bool Baglamafaturaet { get; set; }

    public string Urunbirimtip { get; set; } = null!;

    public double Alannet { get; set; }

    public double Alan { get; set; }

    public double Agirliknet { get; set; }

    public double Agirlik { get; set; }

    public string Tipi { get; set; } = null!;

    public string Hammaddefiyatbirimi { get; set; } = null!;

    public string Uygulamasekli { get; set; } = null!;

    public string Yaldiz { get; set; } = null!;

    public string Holtmelt { get; set; } = null!;

    public string Perfore { get; set; } = null!;

    public string Laminasyon { get; set; } = null!;

    public string Acan { get; set; } = null!;

    public string Rpt { get; set; } = null!;

    public byte Cesit { get; set; }

    public byte Montaj { get; set; }

    public double Yapistirmapayi { get; set; }

    public bool Devamlilik { get; set; }

    public bool Ortfiyatvar { get; set; }

    public DateTime? Fiyattarih { get; set; }

    public double Eurokur { get; set; }

    public double Dolarkur { get; set; }

    public double Eurobarite { get; set; }

    public double Sabitkur { get; set; }

    public double Genelgideryuzde { get; set; }

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string? Ek3 { get; set; }

    public string? Ek4 { get; set; }

    public string? Ek5 { get; set; }

    public string? Ek6 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
