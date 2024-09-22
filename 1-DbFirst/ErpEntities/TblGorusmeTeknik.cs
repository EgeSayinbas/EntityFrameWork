using System;
using System.Collections.Generic;

namespace _1_DbFirst.ErpEntities;

public partial class TblGorusmeTeknik
{
    public int Teknikno { get; set; }

    public string Urunadi { get; set; } = null!;

    public string Musterikod { get; set; } = null!;

    public string Nasilyapis { get; set; } = null!;

    public string Rulotabaka { get; set; } = null!;

    public short Iccap { get; set; }

    public short Discap { get; set; }

    public int Bobindeadet { get; set; }

    public string Akisyonu { get; set; } = null!;

    public double Tekebadboy { get; set; }

    public double Tekebaden { get; set; }

    public double Aabosluk { get; set; }

    public double Tasiyicien { get; set; }

    public double Radus { get; set; }

    public string Urunkod { get; set; } = null!;

    public string Malzemeadi { get; set; } = null!;

    public string Yapiskan { get; set; } = null!;

    public string Yapiskanadi { get; set; } = null!;

    public bool Baskili { get; set; }

    public bool Serigafi { get; set; }

    public bool Trignomi { get; set; }

    public bool Cifttaraf { get; set; }

    public bool Lak { get; set; }

    public string Yuzey { get; set; } = null!;

    public string Aylikkulanim { get; set; } = null!;

    public string Ambalaj { get; set; } = null!;

    public string Koliadet { get; set; } = null!;

    public string Ambalajnot { get; set; } = null!;

    public string Aciklama { get; set; } = null!;

    public string Rafomru { get; set; } = null!;

    public bool Degiskenbaski { get; set; }

    public string Baskiadi { get; set; } = null!;

    public string Ozelsart { get; set; } = null!;

    public string Bicak { get; set; } = null!;

    public string? Olusturanadisoyadi { get; set; }

    public DateTime? Olusturmatarihi { get; set; }
}
