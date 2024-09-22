using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblDegisen
{
    public long Degisenid { get; set; }

    public string Firmakod { get; set; } = null!;

    public string Bagla { get; set; } = null!;

    public string Degisenbolum { get; set; } = null!;

    public string Degisenalan { get; set; } = null!;

    public string Degisenveri { get; set; } = null!;

    public string Yeniveri { get; set; } = null!;

    public string Desigtirenadisoyadi { get; set; } = null!;

    public DateTime Degistirmetarihi { get; set; }
}
