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

        public async Task AddContactDetail(ContactInformationCreateDto contactInformation)
        {
            var contact = _context.Contacts.Where(i => i.Id == contactInformation.ContactId);

            var Contact = "";
            //_context.ContactInformations.AddAsync()


        }

        public async Task<List<Contact>> GetContactWithContactInformation()
        {
            return await _context.Contacts.Include(x => x.ContactInformations).ToListAsync();
        }
    }
}
