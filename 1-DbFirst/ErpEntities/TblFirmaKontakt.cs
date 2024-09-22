using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblFirmaKontakt
{
    public string Firmakod { get; set; } = null!;

    public string Kisikod { get; set; } = null!;

    public string Ad { get; set; } = null!;

    public string Iptalet { get; set; } = null!;

    public string Departman { get; set; } = null!;

    public string Gorevi { get; set; } = null!;

    public DateTime? Dogumtarihi { get; set; }

    public string Hobiler { get; set; } = null!;

    public string Adres1 { get; set; } = null!;

    public string Adres2 { get; set; } = null!;

    public string Postakod { get; set; } = null!;

    public string Ilcekod { get; set; } = null!;

    public string Ilkod { get; set; } = null!;

    public string Ulkekod { get; set; } = null!;

    public string Telefon1 { get; set; } = null!;

    public string Mail { get; set; } = null!;

    public string Esadi { get; set; } = null!;

    public DateTime? Esdogum { get; set; }

    public DateTime? Evliliktarih { get; set; }

    public string Spor { get; set; } = null!;

    public string Takimi { get; set; } = null!;

    public string Evhayvani { get; set; } = null!;

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string? Ek3 { get; set; }

    public string? Ek4 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }

    public virtual TblFirma FirmakodNavigation { get; set; } = null!;
}
