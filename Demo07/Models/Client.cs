using System;
using System.Collections.Generic;

namespace Demo07.Models;

public partial class Client
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Family { get; set; }

    public string? Patronomic { get; set; }

    public DateTime? Birthday { get; set; }

    public long? Passportseria { get; set; }

    public long? Passportnumber { get; set; }

    public long? Phone { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
