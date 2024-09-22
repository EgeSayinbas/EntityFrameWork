using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblUrunIhtiyac
{
    public long Urunihtiyacid { get; set; }

    public string Urunkod { get; set; } = null!;

    public string Firmakod { get; set; } = null!;

    public string Ambalajkod { get; set; } = null!;

    public double Adetoran { get; set; }

    public double Alanoran { get; set; }

    public double Agirlikoran { get; set; }

    public double Urunoran { get; set; }

    public double Ambalajoran { get; set; }

    public string Urunbirimtip { get; set; } = null!;

    public string Ambalajbirimkod { get; set; } = null!;

    public bool Siparisaktar { get; set; }

    public bool Ambalaj { get; set; }

    public bool Eni { get; set; }

    public double En { get; set; }

    public bool Hammadde { get; set; }

    public long Urunislemid { get; set; }

    public string Islemkod { get; set; } = null!;

    public string Aciklama { get; set; } = null!;

    public long Urunmalzemeid { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
