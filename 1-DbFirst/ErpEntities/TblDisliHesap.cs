using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblDisliHesap
{
    public string Dislisayisi { get; set; } = null!;

    public string Dislisayisi2 { get; set; } = null!;

    public string Dislisayisi3 { get; set; } = null!;

    public short Aaadet { get; set; }

    public float Boy { get; set; }

    public float? Cevre { get; set; }

    public double Dislidegeri { get; set; }
}
