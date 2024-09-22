using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblGerceklesenSati
{
    public DateTime? Tarih { get; set; }

    public string Ay { get; set; } = null!;

    public string Yil { get; set; } = null!;

    public double Gerceklesen { get; set; }

    public double Fatura { get; set; }
}
