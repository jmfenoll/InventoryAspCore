using System;
using System.Collections.Generic;

namespace Inventory.Infrastructure.Models;

public class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Quantity { get; set; }
}
