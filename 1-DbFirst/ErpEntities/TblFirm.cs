using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblFirm
{
    public short FirmId { get; set; }

    public string FirmAd { get; set; } = null!;

    public virtual ICollection<TblFirmaFirma> TblFirmaFirmas { get; set; } = new List<TblFirmaFirma>();
}
