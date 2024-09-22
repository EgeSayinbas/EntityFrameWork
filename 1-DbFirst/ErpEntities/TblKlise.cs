using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblKlise
{
    public string Kliseno { get; set; } = null!;

    public string Kliseadi { get; set; } = null!;

    public int Arsivno { get; set; }

    public string Ozelbilgi { get; set; } = null!;

    public string Grafikonay { get; set; } = null!;

    public string Onaykisi { get; set; } = null!;

    public string Tram { get; set; } = null!;

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string? Ek3 { get; set; }

    public string? Ek4 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
