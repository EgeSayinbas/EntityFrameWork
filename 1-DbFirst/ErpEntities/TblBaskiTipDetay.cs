using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblBaskiTipDetay
{
    public long BaskitipaltId { get; set; }

    public string Baskitipkod { get; set; } = null!;

    public int Mamultipkod { get; set; }

    public double Azyogunluk { get; set; }

    public double Cokyogunluk { get; set; }
}
