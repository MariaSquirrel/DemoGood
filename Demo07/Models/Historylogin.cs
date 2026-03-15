using System;
using System.Collections.Generic;

namespace Demo07.Models;

public partial class Historylogin
{
    public int Id { get; set; }

    public DateTime? Datelogint { get; set; }

    public int? UserId { get; set; }

    public bool? Success { get; set; }

    public virtual User? User { get; set; }
}
