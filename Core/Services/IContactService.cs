using Core.Custom;
using Core.Dto;
using Core.Models;

namespace Core.Services
{
    public interface IContactService:IService<Contact>
    {
        Task<ResponseDto<List<ContactWithContactInformationDto>>> GetContactWithContactInformation();

      

      
    }
}
