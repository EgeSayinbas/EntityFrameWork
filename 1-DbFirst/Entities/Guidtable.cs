using System;
using System.Collections.Generic;

namespace _1_DbFirst.Entities;

public partial class Guidtable
{
    public Guid Id { get; set; }

    public string? Ad { get; set; }

    public string? Soyad { get; set; }
}
