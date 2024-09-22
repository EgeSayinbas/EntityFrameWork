using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblSiparisTermin
{
    public long Terminid { get; set; }

    public int Siparisno { get; set; }

    public double Siparismiktar { get; set; }

    public DateTime Termintarih { get; set; }

    public string Firmakod { get; set; } = null!;

    public string Subekod { get; set; } = null!;

    public bool Stok { get; set; }

    public short Iccap { get; set; }

    public short Discap { get; set; }

    public int Bobindeadet { get; set; }

    public string Bobindebirim { get; set; } = null!;

    public string Akisyonu { get; set; } = null!;

    public short Musteriyyadet { get; set; }

    public string Sevkiyatkod { get; set; } = null!;

    public string Terminnot { get; set; } = null!;
}
