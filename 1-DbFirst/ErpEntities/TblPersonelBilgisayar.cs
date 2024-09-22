using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblPersonelBilgisayar
{
    public long Bilid { get; set; }

    public string Personelkodu { get; set; } = null!;

    public string Adi { get; set; } = null!;

    public string Cinsi { get; set; } = null!;

    public string Seviye { get; set; } = null!;

    public string Aciklama { get; set; } = null!;
}
