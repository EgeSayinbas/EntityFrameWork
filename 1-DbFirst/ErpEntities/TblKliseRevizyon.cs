using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblKliseRevizyon
{
    public string Klisekod { get; set; } = null!;

    public string Revizyonkod { get; set; } = null!;

    public string Kliserevizyonsebepkod { get; set; } = null!;

    public string? Aciklama { get; set; }

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
