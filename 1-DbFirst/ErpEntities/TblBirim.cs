using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblBirim
{
    public string Birimkod { get; set; } = null!;

    public string Kodaciklama { get; set; } = null!;

    public string Birimtip { get; set; } = null!;

    public double Oran { get; set; }

    public string Simge { get; set; } = null!;

    public string Teklifbirimikullan { get; set; } = null!;

    public string Kodaciklamaing { get; set; } = null!;

    public string Simgeing { get; set; } = null!;

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
