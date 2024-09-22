using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblSiparisMakina
{
    public long Siparismakinaid { get; set; }

    public int Siparisno { get; set; }

    public string Makinakodu { get; set; } = null!;

    public short Sira { get; set; }

    public int Siralama { get; set; }

    public short Ekgecis { get; set; }

    public bool Bitti { get; set; }

    public DateTime? Plantarih { get; set; }

    public int Topsetupsure { get; set; }

    public double Topislemsure { get; set; }

    public double Islemmiktar { get; set; }

    public bool Aktif { get; set; }

    public bool Sirada { get; set; }

    public string Makinabirimkod { get; set; } = null!;

    public string Uretimnotu { get; set; } = null!;

    public bool Uretimplanlama { get; set; }

    public string Uretimtakip { get; set; } = null!;

    public DateTime? Bitistarihi { get; set; }

    public string Bitiren { get; set; } = null!;

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string? Ek3 { get; set; }

    public string? Olusturanadisoyadi { get; set; }

    public DateTime? Olusturmatarihi { get; set; }
}
