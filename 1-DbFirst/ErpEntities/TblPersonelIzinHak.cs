using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblPersonelIzinHak
{
    public int Izinid { get; set; }

    public string Personelkodu { get; set; } = null!;

    public DateTime Ilktarih { get; set; }

    public DateTime Sontarih { get; set; }

    public short Hakedilen { get; set; }

    public short Kullanilan { get; set; }

    public string Aciklama { get; set; } = null!;

    public string Izintakibi { get; set; } = null!;
}
