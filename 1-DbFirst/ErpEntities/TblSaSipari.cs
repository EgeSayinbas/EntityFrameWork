using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblSaSipari
{
    public int Said { get; set; }

    public int Sasiparisno { get; set; }

    public string Sira { get; set; } = null!;

    public string Sabagkod { get; set; } = null!;

    public int Istekkod { get; set; }

    public int Sateklifkod { get; set; }

    public string Uruntipkod { get; set; } = null!;

    public string Urunkod { get; set; } = null!;

    public int Siparisno { get; set; }

    public bool Bicak { get; set; }

    public string Bicakkodu { get; set; } = null!;

    public string Satipi { get; set; } = null!;

    public bool Klise { get; set; }

    public string? Kliseno { get; set; }

    public bool Detaysiz { get; set; }

    public string Birimkod { get; set; } = null!;

    public string Urunbirimkod { get; set; } = null!;

    public double Birimoran { get; set; }

    public double Miktar1 { get; set; }

    public double Miktar2 { get; set; }

    public int Tabaka { get; set; }

    public double Netmiktar { get; set; }

    public string Kagittipi { get; set; } = null!;

    public double Fiyat { get; set; }

    public string Dovizkod { get; set; } = null!;

    public double Tutar { get; set; }

    public double Kur { get; set; }

    public double Fiyattl { get; set; }

    public double Tutartl { get; set; }

    public double Vade { get; set; }

    public double Kdv { get; set; }

    public DateTime? Siparistarih { get; set; }

    public DateTime? Termintarih { get; set; }

    public string Firmakod { get; set; } = null!;

    public string Firmasiparisno { get; set; } = null!;

    public string Firmasip { get; set; } = null!;

    public string Kisikod { get; set; } = null!;

    public string Aciklama { get; set; } = null!;

    public string Aciklama2 { get; set; } = null!;

    public string Yonetimonay { get; set; } = null!;

    public string Yonetimonay2 { get; set; } = null!;

    public string Klisefirmakod { get; set; } = null!;

    public string Klisegondermekod { get; set; } = null!;

    public string Klisesaklamakod { get; set; } = null!;

    public bool Kromolin { get; set; }

    public string Personelkodu { get; set; } = null!;

    public bool Numunesivar { get; set; }

    public bool? Yeniurun { get; set; }

    public DateTime? Gondermetarih { get; set; }

    public bool KontrolKapat { get; set; }

    public string Tasarimci { get; set; } = null!;

    public string Malzemekodu { get; set; } = null!;

    public double En { get; set; }

    public double Boy { get; set; }

    public double Tekebaden { get; set; }

    public double Tekebadboy { get; set; }

    public string Tedarikcikodu { get; set; } = null!;

    public string Tedarikciadi { get; set; } = null!;

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
