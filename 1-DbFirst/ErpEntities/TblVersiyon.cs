using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblVersiyon
{
    public int VersiyonId { get; set; }

    public string VersiyonAd { get; set; } = null!;

    public short Versiyonmajor { get; set; }

    public short Versiyonminor { get; set; }

    public short Versiyonrevize { get; set; }

    public DateTime Versiyontarih { get; set; }

    public string Versiyonaciklama { get; set; } = null!;
}
