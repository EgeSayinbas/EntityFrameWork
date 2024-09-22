using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblPersonelEgitim
{
    public int PersonelEgitimId { get; set; }

    public string Personelkodu { get; set; } = null!;

    public string Verenadi { get; set; } = null!;

    public string Konu { get; set; } = null!;

    public DateTime Tarih { get; set; }

    public double Sure { get; set; }

    public string Aciklama { get; set; } = null!;

    public bool Firmaici { get; set; }
}
