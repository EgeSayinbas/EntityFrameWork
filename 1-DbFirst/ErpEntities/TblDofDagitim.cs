using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblDofDagitim
{
    public string Dofkod { get; set; } = null!;

    public string Dagitim { get; set; } = null!;

    public string? Personelkodu { get; set; }

    public string? Firmakod { get; set; }

    public string? Kisikod { get; set; }
}
