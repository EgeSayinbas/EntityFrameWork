using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblMakinaGrup
{
    public string Makinagrupkod { get; set; } = null!;

    public string Kodaciklama { get; set; } = null!;

    public short FirmId { get; set; }

    public string Kalipbilgi { get; set; } = null!;

    public short Tanimsira { get; set; }

    public string Adetforma { get; set; } = null!;

    public string UretimdeTakipEt { get; set; } = null!;

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
