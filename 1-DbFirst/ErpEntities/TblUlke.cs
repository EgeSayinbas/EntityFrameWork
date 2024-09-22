using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblUlke
{
    public string Ulkekod { get; set; } = null!;

    public string Ulkead { get; set; } = null!;

    public string UlkeadIngilizce { get; set; } = null!;

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }

    public virtual ICollection<TblFirma> TblFirmas { get; set; } = new List<TblFirma>();
}
