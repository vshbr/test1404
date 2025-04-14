using System;
using System.Collections.Generic;

namespace test1404.Models;

public partial class Company
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Fio { get; set; }

    public virtual ICollection<Phone> Phones { get; set; } = new List<Phone>();
}
