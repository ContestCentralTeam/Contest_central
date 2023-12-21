using Contest_central.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contest_central.Domain.Entities;

public class ProblemLog : BaseEntity
{
    public Guid Contest_id { get; set; }
    public Guid User_id { get; set; }
    public bool Is_solved { get; set; }
    public int Problem_id { get; set; }
}
