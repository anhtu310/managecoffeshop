using System;
using System.Collections.Generic;

namespace ManageCoffee.Models;

public partial class OrderDetail
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public int? Number { get; set; }

    public double? Price { get; set; }

    public double? TotalPrice { get; set; }

    public int? OrderId { get; set; }

    public virtual Order? Order { get; set; }

    public virtual Product? Product { get; set; }
}
