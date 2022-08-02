using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Seeds
{
    internal class ContactSeed : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasData(new Contact { Id = new Guid(),
                Name = "Mehmet", Surname = "ÇİMEN",
                Company="Kayseri Büyükşehir Belediyesi" 
            },
            new Contact
            {
                Id = new Guid(),
                Name = "Mustafa",
                Surname = "ÇİMEN",
                Company = "Kayseri Büyükşehir Belediyesi"
            });

        }
    }
}
