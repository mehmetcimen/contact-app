using AutoMapper;
using Core.Custom;
using Core.Dto;
using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : BaseController
    {

        private readonly IMapper _mapper;
        private readonly IContactService _contactService;

        public ContactsController(IMapper mapper, IService<Contact> service, IContactService contactService)
        {
            _mapper = mapper;
            _contactService = contactService;
        }


        [HttpGet("[action]")]
        public async Task<IActionResult> GetContactWithContactInformation()
        {
            return CreateActionResult(await _contactService.GetContactWithContactInformation());
        }


        [HttpGet]
        public async Task<IActionResult> All()
        {
            var contact = await _contactService.GetAllAsync();
            var contactDto = _mapper.Map<List<ContactDto>>(contact.ToList());

            return CreateActionResult(ResponseDto<List<ContactDto>>.Success(200, contactDto));
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var contact = await _contactService.GetByIdAsync(id);
            var contactDto = _mapper.Map<ContactDto>(contact);
            return CreateActionResult(ResponseDto<ContactDto>.Success(200, contactDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(ContactCreateDto contactDto)
        {
            var contact = await _contactService.AddAsync(_mapper.Map<Contact>(contactDto));
            var contactsDto = _mapper.Map<ContactCreateDto>(contact);
            return CreateActionResult(ResponseDto<ContactCreateDto>.Success(201, contactsDto));
        }

        // DELETE api/contact/5
        [HttpPut]
        public async Task<IActionResult> Update(ContactUpdateDto contactDto)
        {
             await _contactService.UpdateAsync(_mapper.Map<Contact>(contactDto));

            return CreateActionResult(ResponseDto<NoContentDto>.Success(204));
        }


        // DELETE api/contact/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var contact = await _contactService.GetByIdAsync(id);

            await _contactService.RemoveAsync(contact);

            return CreateActionResult(ResponseDto<NoContentDto>.Success(204));
        }



    }
}
