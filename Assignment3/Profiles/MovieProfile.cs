using Assignment3.Models;
using Assignment3.Models.DTO.Movie;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            //Movie<->MovieReadDTO
            CreateMap<Movie, MovieReadDTO>()
                        .ForMember(adto => adto.Franchise, opt => opt
                        .MapFrom(a => a.FranchiseId))
                        .ReverseMap();
            //Movie<->MovieCreateDTO
            CreateMap<Movie, MovieCreateDTO>()
                        .ForMember(adto => adto.Franchise, opt => opt
                        .MapFrom(a => a.FranchiseId))
                        .ReverseMap();
            //Movie<->MovieEditDTO
            CreateMap<Movie, MovieEditDTO>()
                        .ForMember(adto => adto.Franchise, opt => opt
                        .MapFrom(a => a.FranchiseId))
                        .ReverseMap();
        }
    }
}
