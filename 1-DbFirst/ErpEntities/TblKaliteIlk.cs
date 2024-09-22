using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblKaliteIlk
{
    public long Kaliteilkid { get; set; }

    public DateTime? Tarih { get; set; }

    public long Teslimno { get; set; }

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
