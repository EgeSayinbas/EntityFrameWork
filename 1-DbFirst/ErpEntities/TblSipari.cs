using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblSipari
{
    public int Siparisno { get; set; }

    public string Urunkod { get; set; } = null!;

    public string Revizyonkod { get; set; } = null!;

    public double Siparismiktar { get; set; }

    public string Birimkod { get; set; } = null!;

    public DateTime Siparistarih { get; set; }

    public string Siparisbirim { get; set; } = null!;

    public double Siparisfiyat { get; set; }

    public string Dovizkod { get; set; } = null!;

    public int Maliyetkodu { get; set; }

    public string Firmakod { get; set; } = null!;

    public short FirmId { get; set; }

    public double Kdv { get; set; }

    public string Kisikod { get; set; } = null!;

    public string Ozelbilgi { get; set; } = null!;

    public double Bicakfiyat { get; set; }

    public string Bdovizkod { get; set; } = null!;

    public string Bbirim { get; set; } = null!;

    public double Klisefiyat { get; set; }

    public string Kdovizkod { get; set; } = null!;

    public short Kliseadet { get; set; }

    public bool Bfaturaet { get; set; }

    public bool Bfaturaedildi { get; set; }

    public bool Kfaturaet { get; set; }

    public bool Kfaturaedildi { get; set; }

    public double Uygulamamiktar { get; set; }

    public bool KontrolKapat { get; set; }

    public DateTime? Kapattarih { get; set; }

    public bool KontrolDepo { get; set; }

    public bool KontrolKapat2 { get; set; }

    public double Toplamalan { get; set; }

    public double Toplamagirlik { get; set; }

    public double Toplamadet { get; set; }

    public double Toplamteslimmiktar { get; set; }

    public string Personelkodu { get; set; } = null!;

    public string Temsilci { get; set; } = null!;

    public bool Imalattakip { get; set; }

    public int Tramyogunlugu { get; set; }

    public double Gelirtutar { get; set; }

    public double Gelirtutarklise { get; set; }

    public double Gelirtutarbicak { get; set; }

    public double Gidertutar { get; set; }

    public double Gidertutarkur { get; set; }

    public double Maliyetadet { get; set; }

    public double Toplamteslim { get; set; }

    public DateTime? Muhtemeltarih { get; set; }

    public DateTime? Planlanantarih { get; set; }

    public bool Depodan { get; set; }

    public bool Ilkdefa { get; set; }

    public string Ilkdefauy { get; set; } = null!;

    public bool Revizyonvar { get; set; }

    public bool Eskifilmat { get; set; }

    public bool Revizyonfilmdegil { get; set; }

    public string Revizyonnot { get; set; } = null!;

    public string Irsaliyenot { get; set; } = null!;

    public string Faturanot { get; set; } = null!;

    public string Musterisano { get; set; } = null!;

    public string Onayadres { get; set; } = null!;

    public int Oncekilot { get; set; }

    public bool Iptal { get; set; }

    public bool Prova { get; set; }

    public double Globalfiyat { get; set; }

    public string Yeniurun { get; set; } = null!;

    public string Urunacildi { get; set; } = null!;

    public double Satistltutar { get; set; }

    public bool Bedelsiz { get; set; }

    public byte Satistipi { get; set; }

    public string Testtipi { get; set; } = null!;

    public short Numuneadet { get; set; }

    public double Urunalan { get; set; }

    public double Sabitkur { get; set; }

    public string Grafikpersonel { get; set; } = null!;

    public string Grafikonay { get; set; } = null!;

    public string Kardes { get; set; } = null!;

    public string Siparisurunadi { get; set; } = null!;

    public string Siparismusterikod { get; set; } = null!;

    public double Siparistekebadboy { get; set; }

    public double Siparistekebaden { get; set; }

    public double Siparistekebadyukseklik { get; set; }

    public short Siparisyyadet { get; set; }

    public double Siparisaabosluk { get; set; }

    public double Siparisyybosluk { get; set; }

    public short Siparisyybitisikadet { get; set; }

    public double Siparisbaskiaabosluk { get; set; }

    public double Siparislf { get; set; }

    public double Siparisyapistirmapayi { get; set; }

    public double Sipariscl { get; set; }

    public string Siparisuygulamasekli { get; set; } = null!;

    public string Siparisholtmelt { get; set; } = null!;

    public string Siparisperfore { get; set; } = null!;

    public string Siparisbicakkodu { get; set; } = null!;

    public string Siparisurunnot { get; set; } = null!;

    public bool Siparisadettakim { get; set; }

    public short Siparistakimmiktar { get; set; }

    public string Siparisrulobirim { get; set; } = null!;

    public bool Siparisadettakim2 { get; set; }

    public short Siparistakimmiktar2 { get; set; }

    public double Siparisuruneken { get; set; }

    public bool Siparisdevamlilik { get; set; }

    public string Siparisarsivno { get; set; } = null!;

    public string Siparisboyayogunluk { get; set; } = null!;

    public string Sipariskliseno { get; set; } = null!;

    public double Onaydakibakiye { get; set; }

    public string Bakiyedovizkod { get; set; } = null!;

    public double Onaydakirisk { get; set; }

    public string Riskdovizkod { get; set; } = null!;

    public string Muhasebeonay { get; set; } = null!;

    public string Muhasebeonaylayan { get; set; } = null!;

    public DateTime? Muhasebeonaytarih { get; set; }

    public string Yonetimonay { get; set; } = null!;

    public string Yonetimonaylayan { get; set; } = null!;

    public DateTime? Yonetimonaytarih { get; set; }

    public string Yonetimonay2 { get; set; } = null!;

    public string Yonetimonaylayan2 { get; set; } = null!;

    public DateTime? Yonetimonaytarih2 { get; set; }

    public string Bicakdurum { get; set; } = null!;

    public string Klisedurum { get; set; } = null!;

    public string Malzemedurum { get; set; } = null!;

    public DateTime? Planlamatermintarihi { get; set; }

    public string Carikod { get; set; } = null!;

    public DateTime? Planlamakabultarihi { get; set; }

    public double Iskontoyuzde { get; set; }

    public DateTime? Kapanistarihi { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
