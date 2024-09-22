using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblFirma
{
    public string Tip { get; set; } = null!;

    public string Statu { get; set; } = null!;

    public string Firmakod { get; set; } = null!;

    public string Ozelkod { get; set; } = null!;

    public string Kisaad { get; set; } = null!;

    public string Ticariad { get; set; } = null!;

    public string Faturaadres1 { get; set; } = null!;

    public string Faturaadres2 { get; set; } = null!;

    public string Postakod { get; set; } = null!;

    public string Ilcekod { get; set; } = null!;

    public string Ilkod { get; set; } = null!;

    public string Ulkekod { get; set; } = null!;

    public string Telefon1 { get; set; } = null!;

    public string Telefon2 { get; set; } = null!;

    public string Faks1 { get; set; } = null!;

    public string Faks2 { get; set; } = null!;

    public string Mail { get; set; } = null!;

    public string Web { get; set; } = null!;

    public string Muhasebekod { get; set; } = null!;

    public string Muhasebekodsatis { get; set; } = null!;

    public string Sektorkod { get; set; } = null!;

    public string Sektoraltkod { get; set; } = null!;

    public string Grupkod { get; set; } = null!;

    public string Vergidairesi { get; set; } = null!;

    public string Vergino { get; set; } = null!;

    public string Odemesekli { get; set; } = null!;

    public string Personelkodu { get; set; } = null!;

    public string Personelkodu2 { get; set; } = null!;

    public string Grafikperskod { get; set; } = null!;

    public double Risklimiti { get; set; }

    public string Parabirimi { get; set; } = null!;

    public string Parabirimicari { get; set; } = null!;

    public string Durumfirmakod { get; set; } = null!;

    public DateTime? Sonaktiftarih { get; set; }

    public string Ozelnot { get; set; } = null!;

    public string Irsaliyenot { get; set; } = null!;

    public string Faturanot { get; set; } = null!;

    public bool Istihbaratonay { get; set; }

    public string Istihbaratnot { get; set; } = null!;

    public string Istihbaratpersonelkod { get; set; } = null!;

    public string Tckimlikno { get; set; } = null!;

    public bool Sorunlu { get; set; }

    public string Sorunnot { get; set; } = null!;

    public double Valor { get; set; }

    public string Odemekod { get; set; } = null!;

    public string Sevkiyatkod { get; set; } = null!;

    public short Sevklimit { get; set; }

    public short Kalitefiyat { get; set; }

    public short Kaliteiletisim { get; set; }

    public DateTime? Ilksiparistarihi { get; set; }

    public string Ilksiparispersonel { get; set; } = null!;

    public DateTime? Sonsiparistarihi { get; set; }

    public DateTime? Soniletisimtarihi { get; set; }

    public string Faturatipi { get; set; } = null!;

    public double Sabitkur { get; set; }

    public byte Yuvarlama { get; set; }

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string? Ek3 { get; set; }

    public string? Ek4 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }

    public int? SekId { get; set; }

    public virtual TblSektor? Sek { get; set; }

    public virtual ICollection<TblFirmaFirma> TblFirmaFirmas { get; set; } = new List<TblFirmaFirma>();

    public virtual ICollection<TblFirmaGorusmeler> TblFirmaGorusmelers { get; set; } = new List<TblFirmaGorusmeler>();

    public virtual ICollection<TblFirmaTeslimat> TblFirmaTeslimats { get; set; } = new List<TblFirmaTeslimat>();

    public virtual TblUlke UlkekodNavigation { get; set; } = null!;
}
