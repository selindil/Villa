using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.Entity.Entities
{
    public class Message : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subjecr { get; set; }
        public string MessageCount { get; set; }
    }
}
