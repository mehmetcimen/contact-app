using Core.Models;
using Core.Services;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactAppUnitTest
{
    public class ContactServiceTests
    {
        
    
        private readonly IContactService _contactService;

        public ContactServiceTests(IContactService contactService)
        {
            _contactService = contactService;
        }


      


        [Test]
        public async Task ContactAll_WorksAsync()
        {
            //Arrange
            //Guid contact = Guid.Empty;
            //var contactId = "3c20b2a0-ca38-4750-b7c8-003dfeff1a43";

            //contact = Guid.Parse(contactId);


            //Action
            var contact = await _contactService.GetAllAsync();


            //Assert
           // Assert.Null(contact);
            Assert.NotNull(contact);

        }
    }
}
