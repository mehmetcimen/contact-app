using AutoMapper;
using Core.Dto;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Mapping
{
    public class MapContactProfile: Profile
    {
        public MapContactProfile()
        {
            CreateMap<Contact,ContactCreateDto>().ReverseMap();
            CreateMap<ContactInformation, ContactInformationDto>().ReverseMap();
            CreateMap<Contact, ContactWithContactInformationDto>();


        }
    }
}
