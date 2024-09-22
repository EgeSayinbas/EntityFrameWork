using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblBicakIz
{
    public long BicakizId { get; set; }

    public long BicakId { get; set; }

    public string Bicakiz { get; set; } = null!;

    public DateTime Bicakiztarihi { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
