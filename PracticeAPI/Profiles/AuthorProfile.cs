using AutoMapper;
using PracticeAPI.Models;
using PracticeAPI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeAPI.Profiles
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AutorDto>().ReverseMap();
        }
    }
}
