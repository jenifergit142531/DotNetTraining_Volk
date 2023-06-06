using System;
using System.Collections.Generic;

namespace CoreMVC1.Models;

public partial class Inventory
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public decimal? Price { get; set; }

    public int? Quantity { get; set; }

    public DateTime? Addedon { get; set; }
}
