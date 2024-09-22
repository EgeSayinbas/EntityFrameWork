using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblKliseEbad
{
    public string Klisekod { get; set; } = null!;

    public string Calismano { get; set; } = null!;

    public DateTime? Calismatarih { get; set; }

    public double? Tekebadboy { get; set; }

    public double? Tekebaden { get; set; }

    public short? Aaadet { get; set; }

    public short? Yyadet { get; set; }

    public double? Aabosluk { get; set; }

    public double? Yybosluk { get; set; }

    public short? Yybitisikadet { get; set; }

    public string? Malzemekod { get; set; }

    public double? Alan { get; set; }

    public string? Aciklama { get; set; }

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string? Ek3 { get; set; }

    public string? Ek4 { get; set; }
}
