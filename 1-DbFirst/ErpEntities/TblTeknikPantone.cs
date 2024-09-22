using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblTeknikPantone
{
    public int Teknikno { get; set; }

    public string Pantone { get; set; } = null!;
}
