using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblMakinaKart
{
    public string Makinakodu { get; set; } = null!;

    public string Makinaadi { get; set; } = null!;

    public double Maksboy { get; set; }

    public double Minboy { get; set; }

    public double Maksen { get; set; }

    public double Minen { get; set; }

    public short Makinaek { get; set; }

    public double Genelgiderpayi { get; set; }

    public double Iscilikgideri { get; set; }

    public double Elektrikgideri { get; set; }

    public double Giderkatsayisi { get; set; }

    public double Saatucret { get; set; }

    public double Setup { get; set; }

    public double Setupfire { get; set; }

    public double Yuzdefire { get; set; }

    public string Durumkod { get; set; } = null!;

    public bool Aktif { get; set; }

    public byte Uretimplanlamaadet { get; set; }

    public byte Planlamasirasi { get; set; }

    public bool Kkontrol { get; set; }

    public short Bakiunitesi { get; set; }

    public string Anaislemkod { get; set; } = null!;

    public double Gidersaatucret { get; set; }

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string? Ek3 { get; set; }

    public string? Ek4 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
