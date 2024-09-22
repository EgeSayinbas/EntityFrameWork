using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblDof
{
    public string Dofkod { get; set; } = null!;

    public string Doftipi { get; set; } = null!;

    public short Dofno { get; set; }

    public DateTime? Tarih { get; set; }

    public string Dfof { get; set; } = null!;

    public string Firmakod { get; set; } = null!;

    public string Urunkod { get; set; } = null!;

    public int Siparisno { get; set; }

    public float Miktar { get; set; }

    public string Irsaliyeno { get; set; } = null!;

    public string Tanimi { get; set; } = null!;

    public string Hatanedenibildirim { get; set; } = null!;

    public string Hatanedeni { get; set; } = null!;

    public string Eylembildirim { get; set; } = null!;

    public string Eylem { get; set; } = null!;

    public string Eylemplanlama { get; set; } = null!;

    public DateTime? Sevktarihi { get; set; }

    public string Raporno { get; set; } = null!;

    public string Acanpersonel { get; set; } = null!;

    public string Acankisi { get; set; } = null!;

    public string Acanbolum { get; set; } = null!;

    public string Ilgilikisi { get; set; } = null!;

    public string Ilgilibolum { get; set; } = null!;

    public bool KontrolKapat { get; set; }

    public DateTime Kapattarih { get; set; }

    public string Kapatankisi { get; set; } = null!;

    public string Sonuc { get; set; } = null!;

    public bool Dfgerekli { get; set; }

    public string Dfno { get; set; } = null!;

    public string Onayliyankisi { get; set; } = null!;

    public DateTime Onaytarih { get; set; }

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string? Ek3 { get; set; }

    public string? Ek4 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
