using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contest_central.Application.DTOs.Users
{
    public interface IUserDto
    {
        public string Name { get; set; }   
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
