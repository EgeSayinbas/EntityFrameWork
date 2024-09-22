using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblYapisal3
{
    public string Yapisalkod1 { get; set; } = null!;

    public string Yapisalkod2 { get; set; } = null!;

    public string Yapisalkod3 { get; set; } = null!;

    public string? Kodaciklama { get; set; }

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
