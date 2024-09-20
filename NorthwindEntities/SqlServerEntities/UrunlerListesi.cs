using System;
using System.Collections.Generic;

namespace NorthwindEntities.SqlServerEntities;

public partial class UrunlerListesi
{
    public string Productname { get; set; } = null!;

    public string Categoryname { get; set; } = null!;

    public string Companyname { get; set; } = null!;
}
