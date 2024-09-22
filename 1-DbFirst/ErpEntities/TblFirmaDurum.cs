using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

/// <summary>
/// Firma nin aktif veya pasif durumunu tutan tablo
/// </summary>
public partial class TblFirmaDurum
{
    public long Durumno { get; set; }

    public DateTime Tarih { get; set; }

    public string Firmakod { get; set; } = null!;

    public string Durumfirmakod { get; set; } = null!;

    public string Aciklama { get; set; } = null!;

    public string Olusturanadisoyadi { get; set; } = null!;

    public DateTime Olusturmatarihi { get; set; }

    public virtual TblFirma FirmakodNavigation { get; set; } = null!;
}
