using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models;

public class OrderModel
{
    public int OrderId { get; set; }
    public string ProductId { get; set; }
    public int TypeId { get; set; }
    public string Description { get; set; }
}
