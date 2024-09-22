using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblSaSiparisTeslim
{
    public long Teslimno { get; set; }

    public long Said { get; set; }

    public int Sasiparisno { get; set; }

    public string Sira { get; set; } = null!;

    public double Teslimmiktar1 { get; set; }

    public double Teslimmiktar2 { get; set; }

    public double Teslimnetmiktar { get; set; }

    public double Teslimkur { get; set; }

    public DateTime? Teslimtarih { get; set; }

    public string Irsaliyeno { get; set; } = null!;

    public DateTime? Irsaliyetarih { get; set; }

    public int Hareketno { get; set; }

    public string Faturano { get; set; } = null!;

    public DateTime? Faturatarih { get; set; }

    public double Faturafiyat { get; set; }

    public bool Faturalandi { get; set; }

    public string Dovizkod { get; set; } = null!;

    public double Iskonto { get; set; }

    public DateTime? Kontroltarih { get; set; }

    public string Ambalajbutunluk { get; set; } = null!;

    public string Sevkaraci { get; set; } = null!;

    public string Paletuygunluk { get; set; } = null!;

    public string Etiketkontrolu { get; set; } = null!;

    public string Bobinsarimyonu { get; set; } = null!;

    public string Korona { get; set; } = null!;

    public string Yapisma { get; set; } = null!;

    public string Cekmekontrolu { get; set; } = null!;

    public string Olcukontrolu { get; set; } = null!;

    public string Analizsertifikasi { get; set; } = null!;

    public string Mikronkontolu { get; set; } = null!;

    public string Kabuldurumu { get; set; } = null!;

    public string Kontoleden { get; set; } = null!;

    public string Onayliyan { get; set; } = null!;
}
