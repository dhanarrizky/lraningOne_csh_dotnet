﻿using System;
using System.Collections.Generic;

namespace NewProject.DataAccess.Models;

public partial class OrderDetail
{
    public string InvoiceNumber { get; set; } = null!;

    public long ProductId { get; set; }

    public decimal UnitPrice { get; set; }

    public int Quantity { get; set; }

    public decimal Discount { get; set; }

    public virtual Order InvoiceNumberNavigation { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
