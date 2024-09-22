using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblMamulTip
{
    public int Mamultipkod { get; set; }

    public string Kodaciklama { get; set; } = null!;

    public byte Hatsayisi { get; set; }

    public string Cokyaprak { get; set; } = null!;

    public string Cilt { get; set; } = null!;

    public string Cesit { get; set; } = null!;

    public string Anatip { get; set; } = null!;

    public double Minimumaaaralik { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
