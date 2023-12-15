using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contest_central.Domain.Entities;
public class Log
{
    public Guid ID { get; set; }
    public Guid Contest_id { get; set; }
    public string Name { get; set; }
    public int Duration { get; set; }
    public string Creator { get; set; }
    public int Solved_count { get; set; }
    public int rank { get; set; }
    public int Average_time { get; set; }
    public int Start_time { get; set; }
    public int End_time { get; set;}
}
