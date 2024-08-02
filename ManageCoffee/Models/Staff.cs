﻿using System;
using System.Collections.Generic;

namespace ManageCoffee.Models;

public partial class Staff
{
    public int Id { get; set; }

    public string? Fullname { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
