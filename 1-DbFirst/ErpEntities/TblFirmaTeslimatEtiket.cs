using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblFirmaTeslimatEtiket
{
    public int FirmaEtiketId { get; set; }

    public string Firmakod { get; set; } = null!;

    public string Subekod { get; set; } = null!;

    public string Etikettipi { get; set; } = null!;

    public virtual TblFirmaTeslimat TblFirmaTeslimat { get; set; } = null!;
}
