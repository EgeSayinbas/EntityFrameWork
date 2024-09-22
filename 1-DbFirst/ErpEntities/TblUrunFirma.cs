using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblUrunFirma
{
    public long Urunfirmaid { get; set; }

    public string Urunkod { get; set; } = null!;

    public string Firmakod { get; set; } = null!;

    public int Maliyetkodu { get; set; }

    public short Urunno { get; set; }

    public string Urunfaturaadi { get; set; } = null!;

    public string Urunmusterikod { get; set; } = null!;

    public string Uruncesidi { get; set; } = null!;
}
