using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblSevkiyat
{
    public string Sevkiyatkod { get; set; } = null!;

    public string Kodaciklama { get; set; } = null!;

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
