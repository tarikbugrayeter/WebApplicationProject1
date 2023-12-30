using System;
using System.Collections.Generic;

namespace WebApplicationProject1.Models;

public partial class Victim
{
    public int VictimId { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<SentEmail> SentEmails { get; set; } = new List<SentEmail>();
}
