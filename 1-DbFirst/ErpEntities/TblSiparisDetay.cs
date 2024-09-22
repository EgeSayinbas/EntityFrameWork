using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblSiparisDetay
{
    public double? Siparisno { get; set; }

    public string? Malzemekodu { get; set; }

    public DateTime? TarihCikis { get; set; }

    public short? EnCikis { get; set; }

    public short? BoyCikis { get; set; }

    public DateTime? TarihGiris { get; set; }

    public short? EnGiris { get; set; }

    public short? BoyGiris { get; set; }
}
