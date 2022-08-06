using Core.Dto;
using Core.Models;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class ContactRepository : GenericRepository<Contact>, IContactRepository
    {
        
        public ContactRepository(AppDbContext context) : base(context)
        {

        }

    
        public async Task<List<Contact>> GetContactWithContactInformation()
        {
            var aa = await _context.Contacts.Include(x => x.ContactInformations).ToListAsync();
           
            
            return aa;
        }



        
    }
}
