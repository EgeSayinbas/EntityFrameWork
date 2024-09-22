using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblDepo
{
    public string Depokod { get; set; } = null!;

    public string Kodaciklama { get; set; } = null!;

    public string Durumu { get; set; } = null!;

    public string Depotipi { get; set; } = null!;

    public short FirmId { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
