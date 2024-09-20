using System;
using System.Collections.Generic;

namespace NorthwindEntities.SqlServerEntities;

public partial class Test
{
    public int Id { get; set; }

    public string? Kelimechar { get; set; }

    public string? Kelimevarchar { get; set; }

    public string? KelimeNvarchar { get; set; }

    public DateTime? Tarih { get; set; }
}
