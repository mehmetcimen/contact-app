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
    public class MapContactInformationProfile:Profile
    {
        public MapContactInformationProfile()
        {
            CreateMap<ContactInformation, ContactInformationDto>().ReverseMap();

            CreateMap<ContactInformation, ContactInformationCreateDto>().ReverseMap();
        }
    }
}
