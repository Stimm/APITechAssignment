﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models;

internal class OrderModel
{
    public int OrderId { get; set; }
    public Guid ProductId { get; set; }
    public int TypeId { get; set; }
    public string Description { get; set; }
}