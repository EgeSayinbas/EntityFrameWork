using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblFirmaFirma
{
    public int Firmafirmaid { get; set; }

    public string Firmakod { get; set; } = null!;

    public string Firma { get; set; } = null!;

    public string Alicikod { get; set; } = null!;

    public string Saticikod { get; set; } = null!;

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }

    public short FirmId { get; set; }

    public virtual TblFirm Firm { get; set; } = null!;

    public virtual TblFirma FirmakodNavigation { get; set; } = null!;
}
