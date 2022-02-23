using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models;

public class ProductTypeModel
{
    public int TypeId { get; set; }
    public string Description { get; set; }
    public int Stock { get; set; }
}
