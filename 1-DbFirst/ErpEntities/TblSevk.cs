using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblSevk
{
    public long Sevkno { get; set; }

    public string Belgetipi { get; set; } = null!;

    public string Durumu { get; set; } = null!;

    public string Belgeserino { get; set; } = null!;

    public string Belgesirano { get; set; } = null!;

    public long Faturasevkno { get; set; }

    public short FirmId { get; set; }

    public string Firmakod { get; set; } = null!;

    public string Carikod { get; set; } = null!;

    public string Ilgilikod { get; set; } = null!;

    public string Subekod { get; set; } = null!;

    public string Musterisano { get; set; } = null!;

    public string Sevkiyatkod { get; set; } = null!;

    public DateTime? Belgetarih { get; set; }

    public DateTime? Sevktarih { get; set; }

    public string Sevkiyatnotu { get; set; } = null!;

    public string Aciklama { get; set; } = null!;

    public int Konsinyeno { get; set; }

    public short Vade { get; set; }

    public string Belgedovizkod { get; set; } = null!;

    public double Faturakur { get; set; }

    public double Iskontoyuzde { get; set; }

    public double Iskontotutar { get; set; }

    public double Toplam { get; set; }

    public double Kdv { get; set; }

    public double Yekun { get; set; }

    public string Yaziyla { get; set; } = null!;

    public string Iptal { get; set; } = null!;

    public string Sevktipkod { get; set; } = null!;

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
