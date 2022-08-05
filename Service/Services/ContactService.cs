using AutoMapper;
using Core.Custom;
using Core.Dto;
using Core.Models;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWorks;

namespace Service.Services
{
    public class ContactService : Service<Contact>, IContactService
    {
        private readonly IContactRepository _contactRepository;
        private readonly IMapper _mapper;

        public ContactService(IGenericRepository<Contact> repository, IUnitOfWork unitOfWork,
             IMapper mapper, IContactRepository contactRepository) : base(repository, unitOfWork)
        {

            _mapper = mapper;
            _contactRepository = contactRepository;
        }

       
        public async Task<ResponseDto<List<ContactWithContactInformationDto>>> GetContactWithContactInformation()
        {
            var contacts = await _contactRepository.GetContactWithContactInformation();

            var contactsDto = _mapper.Map<List<ContactWithContactInformationDto>>(contacts);

            return ResponseDto<List<ContactWithContactInformationDto>>.Success(200, contactsDto);


        }
    }
}
