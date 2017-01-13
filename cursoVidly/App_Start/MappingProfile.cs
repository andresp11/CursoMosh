using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using cursoVidly.Models;
using cursoVidly.DTOS;

namespace cursoVidly.App_Start
{
    public class MappingProfile: Profile
    {

        public MappingProfile()
        {
            Mapper.CreateMap<Customers, CustomerDTO>().ForMember(m => m.Id, opt => opt.Ignore());
            Mapper.CreateMap<CustomerDTO, Customers>().ForMember(m => m.Id, opt => opt.Ignore());

            Mapper.CreateMap<Movies, MovieDTO>().ForMember(m => m.Id, opt => opt.Ignore());
            Mapper.CreateMap<MovieDTO, Movies>().ForMember(m => m.Id, opt => opt.Ignore());
        }
    }



}