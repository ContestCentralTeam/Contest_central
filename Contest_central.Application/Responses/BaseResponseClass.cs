using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contest_central.Application.Responses;
public class BaseResponseClass
{
    public string Message { get; set; }
    public bool Success { get; set; } 
    public List<string> Error { get; set; }
}
