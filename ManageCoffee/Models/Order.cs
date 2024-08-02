using System;
using System.Collections.Generic;

namespace ManageCoffee.Models;

public partial class Order
{
    public int Id { get; set; }

    public int? StaffId { get; set; }

    public int? CustomerId { get; set; }

    public double? TotalPrice { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? Note { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual Staff? Staff { get; set; }
}
