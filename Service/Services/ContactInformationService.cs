using AutoMapper;
using Core.Models;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ContactInformationService : Service<ContactInformation>, IContactInformationService
    {

        private readonly IContactInformationRepository _contactInformationRepo;
        private readonly IMapper _mapper;
        public ContactInformationService(IGenericRepository<ContactInformation> repository, IUnitOfWork unitOfWork, IContactInformationRepository contactInformationRepo, IMapper mapper)
            : base(repository, unitOfWork)
        {
            _contactInformationRepo = contactInformationRepo;
            _mapper = mapper;
        }


    }
}
