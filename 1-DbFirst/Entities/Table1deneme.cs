using System;
using System.Collections.Generic;

namespace _1_DbFirst.Entities;

public partial class Table1deneme
{
    public int Id { get; set; }

    public string? Ad { get; set; }

    public string? Soyad { get; set; }

    public string? Sehir { get; set; }

    public DateOnly? Trh1 { get; set; }

    public DateTime? Trh2 { get; set; }

    public TimeOnly? Zaman { get; set; }

    public bool? IsActive { get; set; }

    public decimal? Tutar { get; set; }

    public Guid? Guid { get; set; }
}
