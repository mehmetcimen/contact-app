using AutoMapper;
using Core.Custom;
using Core.Dto;
using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactInformationController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IContactInformationService _service;

        public ContactInformationController(IMapper mapper, IContactInformationService service)
        {
            _mapper = mapper;
            _service = service;
        }


        [HttpGet]
        public async Task<IActionResult> All()
        {
            var contact = await _service.GetAllAsync();
            var contactDto = _mapper.Map<List<ContactInformationDto>>(contact.ToList());

            return CreateActionResult(ResponseDto<List<ContactInformationDto>>.Success(200, contactDto));
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var contact = await _service.GetByIdAsync(id);
            var contactDto = _mapper.Map<ContactDto>(contact);
            return CreateActionResult(ResponseDto<ContactDto>.Success(200, contactDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(ContactInformationCreateDto contactDto)
        {
            var contact = await _service.AddAsync(_mapper.Map<ContactInformation>(contactDto));
            var contactsDto = _mapper.Map<ContactInformationCreateDto>(contact);
            return CreateActionResult(ResponseDto<ContactInformationCreateDto>.Success(201, contactsDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(ContactInformationUpdateDto contactDto)
        {
            await _service.UpdateAsync(_mapper.Map<ContactInformation>(contactDto));

            return CreateActionResult(ResponseDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(Guid id)
        {
            var contact = await _service.GetByIdAsync(id);

            await _service.RemoveAsync(contact);

            return CreateActionResult(ResponseDto<NoContentDto>.Success(204));
        }




    }
}
