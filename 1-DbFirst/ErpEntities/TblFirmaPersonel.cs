using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblFirmaPersonel
{
    public long FirmaPersId { get; set; }

    public string Firmakod { get; set; } = null!;

    public short FirmId { get; set; }

    public string Personelkodu { get; set; } = null!;

    public string Personelgrupkod { get; set; } = null!;

    public string Aciklama { get; set; } = null!;

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }

    public virtual TblFirma FirmakodNavigation { get; set; } = null!;
}
