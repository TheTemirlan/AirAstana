using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Status.Domain.Entities
{
    public class Role
    {
        public string? Code { get; set; }

        public IList<User> Users { get; private set; } = new List<User>();
    }
}
