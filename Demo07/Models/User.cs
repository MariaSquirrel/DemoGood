using System;
using System.Collections.Generic;

namespace Demo07.Models;

public partial class User
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Password { get; set; }

    public string? Login { get; set; }

    public int? RoleId { get; set; }

    public string? Photoname { get; set; }

    public virtual ICollection<Historylogin> Historylogins { get; set; } = new List<Historylogin>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual Role? Role { get; set; }
}
