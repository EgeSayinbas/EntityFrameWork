using System;
using System.Collections.Generic;

namespace _1_DbFirst.SqlServerEntitis;

public partial class CurrentProductList
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;
}
