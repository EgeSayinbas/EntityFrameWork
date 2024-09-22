using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblSektor
{
    public string Sektorkod { get; set; } = null!;

    public string Sektoraltkod { get; set; } = null!;

    public string? Sektoranaad { get; set; }

    public string Sektorad { get; set; } = null!;

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }

    public int SekId { get; set; }

    public virtual ICollection<TblFirma> TblFirmas { get; set; } = new List<TblFirma>();
}
