using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contest_central.Domain.Entities;
public class Problem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Country { get; set; }
    public string University { get; set; }
    public Guid Group_id { get; set; }
    public string url { get; set; }
}
