using System;
using System.Collections.Generic;

namespace _1_DbFirst.SqlServerEntitis;

public partial class Menuler
{
    public int Id { get; set; }

    public string? MenuAdi { get; set; }

    public short? SiraNo { get; set; }

    public int? UstMenuId { get; set; }

    public virtual ICollection<Menuler> InverseUstMenu { get; set; } = new List<Menuler>();

    public virtual Menuler? UstMenu { get; set; }
}
