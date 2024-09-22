using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblFirmaGorusmeler
{
    public long Gorid { get; set; }

    public string Firmakod { get; set; } = null!;

    public short Gorusmeno { get; set; }

    public int Teknikno { get; set; }

    public DateTime? Gorusmetarihi { get; set; }

    public string Gorusmetipno { get; set; } = null!;

    public string Kisikod { get; set; } = null!;

    public string Personelkodu { get; set; } = null!;

    public string Gorusmenotu { get; set; } = null!;

    public bool Gorusmebitti { get; set; }

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string? Ek3 { get; set; }

    public string? Ek4 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }

    public virtual TblFirma FirmakodNavigation { get; set; } = null!;
}
