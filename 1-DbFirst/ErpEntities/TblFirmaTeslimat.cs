using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblFirmaTeslimat
{
    public long Firmateslimatid { get; set; }

    public string Firmakod { get; set; } = null!;

    public string Subekod { get; set; } = null!;

    public string Subead { get; set; } = null!;

    public string Teslimatadres1 { get; set; } = null!;

    public string Teslimatadres2 { get; set; } = null!;

    public string Postakod { get; set; } = null!;

    public string Ilcekod { get; set; } = null!;

    public string Ilkod { get; set; } = null!;

    public string Ulkekod { get; set; } = null!;

    public string Telefon1 { get; set; } = null!;

    public string Telefon2 { get; set; } = null!;

    public string Faks1 { get; set; } = null!;

    public string Faks2 { get; set; } = null!;

    public string Mail { get; set; } = null!;

    public string Web { get; set; } = null!;

    public string Vergidairesi { get; set; } = null!;

    public string Vergino { get; set; } = null!;

    public string Tckimlikno { get; set; } = null!;

    public bool Kullanilmiyor { get; set; }

    public string? Ek1 { get; set; }

    public string? Ek2 { get; set; }

    public string? Ek3 { get; set; }

    public string? Ek4 { get; set; }

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }

    public virtual TblFirma FirmakodNavigation { get; set; } = null!;

    public virtual ICollection<TblFirmaTeslimatEtiket> TblFirmaTeslimatEtikets { get; set; } = new List<TblFirmaTeslimatEtiket>();
}
