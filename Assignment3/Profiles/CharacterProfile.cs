using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment3.Models;
using Assignment3.Models.DTO.Character;
using AutoMapper;

namespace Assignment3.Profiles
{
    public class CharacterProfile : Profile
    {
        public CharacterProfile()
        {
            CreateMap<Character, CharacterReadDTO>().ReverseMap();
            CreateMap<Character, CharacterCreateDTO>().ReverseMap();
            CreateMap<Character, CharacterEditDTO>().ReverseMap();
        }
    }
}
