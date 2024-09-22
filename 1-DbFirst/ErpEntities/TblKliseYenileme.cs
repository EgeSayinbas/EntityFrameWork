using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblKliseYenileme
{
    public string Klisekod { get; set; } = null!;

    public string Yenilemeno { get; set; } = null!;

    public string Klisetipkod { get; set; } = null!;

    public DateTime? Imaltarihi { get; set; }

    public bool Iptal { get; set; }

    public DateTime? Imhatarihi { get; set; }

    public int Tursayisi { get; set; }

    public double Fiyat { get; set; }

    public double Birimfiyat { get; set; }

    public string Birimdovizkod { get; set; } = null!;

    public string Klisesebepkod { get; set; } = null!;

    public string Durumkod { get; set; } = null!;

    public string Firmakod { get; set; } = null!;

    public bool Sipariste { get; set; }

    public bool Kullanimda { get; set; }

    public string Imhasebepkod { get; set; } = null!;

    public string Isteyen { get; set; } = null!;

    public string Sebepkisi { get; set; } = null!;

    public string Siparisno { get; set; } = null!;

    public string Aciklama { get; set; } = null!;

    public double Miktar1 { get; set; }

    public double Miktar2 { get; set; }

    public double Netmiktar { get; set; }

    public long Said { get; set; }

    public int Sasiparisno { get; set; }

    public string Sira { get; set; } = null!;

    public string Klisetakip { get; set; } = null!;

    public string Teslimalan { get; set; } = null!;

    public DateTime? Teslimtarihi { get; set; }

    public DateTime? Gondertarihi { get; set; }

    public string Uretimyeri { get; set; } = null!;

    public bool Cekirdekvar { get; set; }

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }
}
