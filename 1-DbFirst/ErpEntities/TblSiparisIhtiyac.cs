using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblSiparisIhtiyac
{
    public long Sipihtiyacid { get; set; }

    public long Urunihtiyacid { get; set; }

    public int Siparisno { get; set; }

    public string Urunkod { get; set; } = null!;

    public double Miktar { get; set; }

    public string Birimkod { get; set; } = null!;

    public string Birim { get; set; } = null!;

    public double En { get; set; }

    public bool Hammadde { get; set; }

    public string Islemkod { get; set; } = null!;

    public bool Fason { get; set; }

    public double Fire { get; set; }

    public string Ihtiyactakip { get; set; } = null!;

    public string Ihtiyacnotu { get; set; } = null!;
}
