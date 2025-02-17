﻿using System;
using System.Collections.Generic;

namespace ManageCoffee.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string? Fullname { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
