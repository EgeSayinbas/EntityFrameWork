using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblSiparisIslem
{
    public long Siparisislemid { get; set; }

    public long Urunislemid { get; set; }

    public int Siparisno { get; set; }

    public long Siparismakinaid { get; set; }

    public string Islemkod { get; set; } = null!;

    public string Dislisayisi { get; set; } = null!;

    public double Dislidegeri { get; set; }

    public short Aaadet { get; set; }

    public short Yyadet { get; set; }

    public short Islemsayisi { get; set; }
}
