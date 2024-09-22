using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblPersonelKart
{
    public string Personelkodu { get; set; } = null!;

    public bool Aktif { get; set; }

    public bool Calisiyor { get; set; }

    public string Grup { get; set; } = null!;

    public bool Doviz { get; set; }

    public string Grafikyetkili { get; set; } = null!;

    public string Makinaadi { get; set; } = null!;

    public string Oturumadi { get; set; } = null!;

    public bool Sifregir { get; set; }

    public bool Hizligir { get; set; }

    public string Saonay { get; set; } = null!;

    public string Saonay2 { get; set; } = null!;

    public string Firmatemsilcisiatama { get; set; } = null!;

    public string Personelgrupkod { get; set; } = null!;

    public string Unvan { get; set; } = null!;

    public string Sifre2 { get; set; } = null!;

    public DateTime? Baslatarih { get; set; }

    public string Sosyalno { get; set; } = null!;

    public DateTime? Dogumtarih { get; set; }

    public string Dogumyeri { get; set; } = null!;

    public string Medeni { get; set; } = null!;

    public string Askerlik { get; set; } = null!;

    public string Ehliyet { get; set; } = null!;

    public string Kan { get; set; } = null!;

    public string Adres { get; set; } = null!;

    public string Ceptelefon { get; set; } = null!;

    public string Telefon { get; set; } = null!;

    public string Telefon2 { get; set; } = null!;

    public string Saglik { get; set; } = null!;

    public string Aciklama { get; set; } = null!;

    public string Ilkogretim { get; set; } = null!;

    public string Ilkyil { get; set; } = null!;

    public string Lise { get; set; } = null!;

    public string Liseyil { get; set; } = null!;

    public string Yuksekokul { get; set; } = null!;

    public string Yuksekyil { get; set; } = null!;

    public string Lisansustu { get; set; } = null!;

    public string Lisansustuyil { get; set; } = null!;

    public DateTime? Oryantasyontarih { get; set; }

    public string Oryantasyonkisi { get; set; } = null!;

    public bool Nitelik { get; set; }

    public DateTime? Niteliktarih { get; set; }

    public string Niteliknot { get; set; } = null!;

    public string Foto { get; set; } = null!;

    public string Eposta { get; set; } = null!;

    public string Beden { get; set; } = null!;

    public string Ayakno { get; set; } = null!;

    public byte Cocuk { get; set; }

    public double Maas { get; set; }

    public string Bolum { get; set; } = null!;

    public int Izingun { get; set; }

    public int Izinpotansiyel { get; set; }

    public string Servis { get; set; } = null!;

    public short FirmId { get; set; }

    public DateTime? Cikistarih { get; set; }
}
