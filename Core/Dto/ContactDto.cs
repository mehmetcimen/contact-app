using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dto
{
    public class ContactDto
    {
        public DateTime CreatedDate { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; }
    }
}
