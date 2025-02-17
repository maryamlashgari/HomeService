﻿using System;
using System.Collections.Generic;

namespace HomeService.Models.Entities;

public partial class OrderStatue
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
