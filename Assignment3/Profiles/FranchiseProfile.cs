using Assignment3.Models;
using Assignment3.Models.DTO.Franchise;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Profiles
{
    public class FranchiseProfile : Profile
    {
        public FranchiseProfile()
        {
            CreateMap<Franchise, FranchiseReadDTO>().ReverseMap();
            CreateMap<Franchise, FranchiseCreateDTO>().ReverseMap();
            CreateMap<Franchise, FranchiseEditDTO>().ReverseMap();
        }
    }
}
