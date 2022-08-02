using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class ContactInformation: Base
    {
        
        public Guid Id { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }

        public Guid ContactId { get; set; }
        public Contact Contact { get; set; }
       

    }
}
