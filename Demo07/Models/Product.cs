using System;
using System.Collections.Generic;

namespace Demo07.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public decimal? Price { get; set; }

    public int? ManufacturerId { get; set; }

    public virtual Manufacturer? Manufacturer { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
