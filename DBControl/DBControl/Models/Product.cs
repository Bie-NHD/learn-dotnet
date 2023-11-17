using System;
using System.Collections.Generic;

namespace DBControl.Models;

public partial class Product
{
    public int ProductCode { get; set; }

    public string? ProductName { get; set; }

    public int? ProductPrice { get; set; }
}
