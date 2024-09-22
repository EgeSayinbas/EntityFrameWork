using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblPersonelIzin
{
    public long Izinkullanid { get; set; }

    public int Izinid { get; set; }

    public string Personelkodu { get; set; } = null!;

    public DateTime Cikistarih { get; set; }

    public DateTime Gelistarih { get; set; }

    public short Izingun { get; set; }

    public string Aciklama { get; set; } = null!;
}
