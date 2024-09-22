using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblPersonelFirm
{
    public string Personelkodu { get; set; } = null!;

    public short FirmId { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
