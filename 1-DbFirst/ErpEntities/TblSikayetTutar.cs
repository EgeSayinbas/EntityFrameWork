using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblSikayetTutar
{
    public int Sikayettutarid { get; set; }

    public int Sikayetno { get; set; }

    public string Aciklama { get; set; } = null!;

    public double Tutar { get; set; }
}
