using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contest_central.Domain.Entities;
public class Contest
{
    public Guid Id { get; set; }
    public DateTime DateTime { get; set; }
    public string Name { get; set; }
    public int Duration { get; set; }
    public Guid Creator_id { get; set; }
    public string Profile_pic { get; set; }
}
