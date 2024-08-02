using System;
using System.Collections.Generic;

namespace ManageCoffee.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Thumbnail { get; set; }

    public string? Description { get; set; }

    public double? Price { get; set; }

    public int? IdCat { get; set; }

    public string? Status { get; set; }

    public virtual Category? IdCatNavigation { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
