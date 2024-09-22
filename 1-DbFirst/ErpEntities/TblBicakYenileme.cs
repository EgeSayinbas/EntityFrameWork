using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblBicakYenileme
{
    public string Bicakkodu { get; set; } = null!;

    public string Yenilemeno { get; set; } = null!;

    public string Serino { get; set; } = null!;

    public bool Iptal { get; set; }

    public string Durumkod { get; set; } = null!;

    public string Firmakod { get; set; } = null!;

    public DateTime? Imaltarihi { get; set; }

    public DateTime? Imhatarihi { get; set; }

    public DateTime? Fiilitarih { get; set; }

    public string Bicaksebepkod { get; set; } = null!;

    public int Tursayisi { get; set; }

    public double Fiyat { get; set; }

    public bool Kullanimda { get; set; }

    public bool Sipariste { get; set; }

    public int Sasiparisno { get; set; }

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string? Olusturanadisoyadi { get; set; }

    public DateTime? Olusturmatarihi { get; set; }
}
